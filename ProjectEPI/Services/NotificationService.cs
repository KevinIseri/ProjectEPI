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
            var currentNotifications = GetExistingNotifications();
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

        public List<long> GetExistingNotifications()
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
                _labelMainNotificationNumber.Text = equipmentIdsWithNotifications.Count().ToString();

                return equipmentIdsWithNotifications;
            });
        }
    }
}
