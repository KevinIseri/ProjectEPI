using ProjectEPI.Data;
using static ProjectEPI.Constants.EquipmentConstants;

namespace ProjectEPI.Services
{
    public class NotificationService
    {
        private readonly EquipmentService _equipmentService;
        private readonly DatabaseManager _databaseManager;
        private readonly SettingService _settingService;
        private readonly Label _labelMainNotificationNumber;

        public NotificationService(
            DatabaseManager databaseManager , 
            EquipmentService equipmentService, 
            SettingService settingService,
            Label labelMainNotificationNumber)
        {
            _equipmentService = equipmentService;
            _databaseManager = databaseManager;
            _settingService = settingService;
            _labelMainNotificationNumber = labelMainNotificationNumber;
        }

        public void GenerateNotifications()
        {
            var currentNotifications = GetExistingNotificationsIds();
            var equipments = _equipmentService.GetEquipments();

            var daysLimit = _settingService.GetMaturityIntervalDays();

            var incNotifications = 0;

            foreach (var equipment in equipments)
            {
                if (ShouldCreateNotification(equipment, daysLimit, currentNotifications))
                {
                    CreateNotification(equipment.Id);
                    incNotifications += 1;
                }
            }

            var notificationNumberUpdated = currentNotifications.Count() + incNotifications;
            _labelMainNotificationNumber.Text = notificationNumberUpdated.ToString();
        }

        private static bool ShouldCreateNotification(EquipmentData equipment, int daysLimit, List<long> currentNotifications)
        {
            if (equipment.MaturityDate == null) throw new Exception($"Equipamento Id '{equipment.Id}' não possui data de vencimento");

            if (!equipment.IsActive || 
                equipment.HandlingStatus == HandlingStatus.FINISHED || 
                currentNotifications.Contains(equipment.Id))
            {
                return false;
            }

            var remainingDays = (equipment.MaturityDate.Value.Date - DateTime.Today).Days;

            return remainingDays <= daysLimit;
        }

        private void CreateNotification(long equipmentId)
        {
            var query = "INSERT INTO public.notifications (equipmentid, created_date) VALUES (@equipmentId, @createdDate)";
            _databaseManager.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
            });

            var queryUpdate = "UPDATE public.equipments SET handling_status = @handlingstatus, status = @status WHERE id = @equipmentId";
            _databaseManager.ExecuteNonQuery(queryUpdate, cmd =>
            {
                cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                cmd.Parameters.AddWithValue("@handlingstatus", HandlingStatus.PENDING);
                cmd.Parameters.AddWithValue("@status", EquipmentStatus.EXPIRING);
            });


        }

        public List<long> GetExistingNotificationsIds()
        {
            var query = "SELECT equipmentid FROM notifications";

            return _databaseManager.ExecuteScalar(query, cmd =>
            {
                var equipmentIdsWithNotifications = new List<long>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipmentIdsWithNotifications.Add((long)reader["equipmentid"]);
                    }
                }
                _labelMainNotificationNumber.Text = equipmentIdsWithNotifications.Count.ToString();

                return equipmentIdsWithNotifications;
            });
        }

        public List<NotificationData> GetExistingNotifications()
        {

            var query = "SELECT n.Id, n.EquipmentId, n.Created_Date, n.Updated_Date, e.Id as EquipmentId, e.Name, e.Ca, e.Description, e.IsActive, e.Maturity_Date, e.Status, e.Handling_Status " +
                        "FROM notifications n " +
                        "INNER JOIN equipments e ON n.EquipmentId = e.Id";

            return _databaseManager.ExecuteScalar(query, cmd =>
            {
                var notifications = new List<NotificationData>();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var notification = new NotificationData
                        {
                            Id = (long)reader["Id"],
                            Equipment = new EquipmentData
                            {
                                Id = (long)reader["EquipmentId"],
                                Name = reader["Name"].ToString(),
                                Ca = reader["Ca"].ToString(),
                                Description = reader["Description"].ToString(),
                                IsActive = (bool)reader["IsActive"],
                                MaturityDate = reader["Maturity_Date"] != DBNull.Value ? (DateTime?)reader["Maturity_Date"] : null,
                                Status = reader["Status"].ToString(),
                                HandlingStatus = reader["Handling_Status"].ToString()
                            }
                        };
                        notifications.Add(notification);
                    }
                }
                _labelMainNotificationNumber.Text = notifications.Count.ToString();

                return notifications;
            });
        }
    }
}
