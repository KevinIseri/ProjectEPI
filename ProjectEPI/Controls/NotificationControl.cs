using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class NotificationControl : UserControl
    {
        private NotificationService _notificationService;

        public NotificationControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(NotificationService notificationService)
        {
            _notificationService = notificationService;

            ShowNotificationGrid();
        }

        public void ShowNotificationGrid()
        {
            var notifications = _notificationService.GetExistingNotifications();

            NotificationDataGridView.Columns.Clear();

            NotificationDataGridView.Columns.Add("NotificationId", "ID da notificação");

            NotificationDataGridView.Columns.Add("EquipmentId", "ID do equipamento");
            NotificationDataGridView.Columns.Add("EquipmentCa", "CA");
            NotificationDataGridView.Columns.Add("EquipmentName", "Nome do equipamento");
            NotificationDataGridView.Columns.Add("EquipmentDescription", "Descrição do equipamento");
            NotificationDataGridView.Columns.Add("EquipmentMaturityDate", "Data de vencimento");

            foreach (var notification in notifications)
            {
                var rowIndex = NotificationDataGridView.Rows.Add();
                var row = NotificationDataGridView.Rows[rowIndex];

                row.Cells["NotificationId"].Value = notification.Id;

                row.Cells["EquipmentId"].Value = notification.Equipment.Id;
                row.Cells["EquipmentCa"].Value = notification.Equipment.Ca;
                row.Cells["EquipmentName"].Value = notification.Equipment.Name;
                row.Cells["EquipmentDescription"].Value = notification.Equipment.Description;
                row.Cells["EquipmentMaturityDate"].Value = notification.Equipment.MaturityDate?.ToString("dd/MM/yyyy");
            }

        }
    }
}
