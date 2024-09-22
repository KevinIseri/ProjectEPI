using ProjectEPI.Data;
using static ProjectEPI.Constants.EquipmentConstants;

namespace ProjectEPI.Services
{
    public class NotificationService
    {
        private readonly EquipmentService _equipmentService;
        private readonly DatabaseManager _databaseManager;
        private readonly SettingService _settingService;

        public NotificationService(
            DatabaseManager databaseManager , 
            EquipmentService equipmentService, 
            SettingService settingService)
        {
            _equipmentService = equipmentService;
            _databaseManager = databaseManager;
            _settingService = settingService;
        }

        /*
         olhar status isactive, handlingStatus (pendente VERMELHO, em andamento LARANJA, finalizado VERDE)
         e status(Em conformidade VERDE, A vencer LARANJA, Vencido VERMELHO)
            no caso nao criar se estivar inative e nas tratativas como, concluído??

        ao criar verificar se o equipamento ja existe uma notificação atrelada

        ver sobre status em andamento

        MATURITY_THRESHOLD deve criar para todos ativos e diferente de finalizado, 
        caso nao exista alerta atrelado ao equipamento

        handlingstatus como finalizado deve excluir uma notificação atrelada caso exista

        criar modal de notificação no windows?
         
         */

        public void GenerateNotifications()
        {
            var currentNotifications = GetExistingNotifications(); // fazer na inicialização do programa
            var equipments = _equipmentService.GetEquipments();

            var limitDate = DateTime.Now.AddDays(-_settingService.GetMaturityIntervalDays());
            //var limitThreshold = DateTime.Now;

            foreach (var equipment in equipments)
            {
                if (ShouldCreateNotification(equipment, limitDate, currentNotifications))
                {
                    CreateNotification(equipment.Id);
                }
            }
        }

        private static bool ShouldCreateNotification(EquipmentData equipment, DateTime limitDate, List<long> currentNotifications)
        {
            if (equipment.MaturityDate == null) throw new Exception($"Equipamento Id '{equipment.Id}' não possui data de vencimento");

            if (!equipment.IsActive || 
                equipment.HandlingStatus == HandlingStatus.FINISHED || 
                currentNotifications.Contains(equipment.Id))
            {
                return false;
            }

            return equipment.MaturityDate.Value.Date <= limitDate.Date;
        }

        private void CreateNotification(long equipmentId)
        {
            var query = "INSERT INTO public.notifications (equipment_id, created_date) VALUES (@equipmentId, @createdDate)";
            _databaseManager.ExecuteNonQuery(query, cmd =>
            {
                cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
            });

            var updateQuery = "UPDATE public.equipments SET handling_status = @handlingstatus, status = @status WHERE id = @equipmentId";
            _databaseManager.ExecuteNonQuery(updateQuery, cmd =>
            {
                cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                cmd.Parameters.AddWithValue("@handlingstatus", HandlingStatus.PENDING);
                cmd.Parameters.AddWithValue("@status", EquipmentStatus.EXPIRING);
            });
        }

        public List<long> GetExistingNotifications()
        {
            var query = "SELECT equipment_id FROM notifications";

            return _databaseManager.ExecuteScalar(query, cmd =>
            {
                var equipmentIdsWithNotifications = new List<long>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipmentIdsWithNotifications.Add((long)reader["equipment_id"]);
                    }
                }
                return equipmentIdsWithNotifications;
            });
        }
    }
}
