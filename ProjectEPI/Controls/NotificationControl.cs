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

            NotificationDataGridView.Columns.Add("EquipmentId", "ID do equipamento");
            NotificationDataGridView.Columns.Add("EquipmentCa", "CA");
            NotificationDataGridView.Columns.Add("EquipmentName", "Nome do equipamento");
            NotificationDataGridView.Columns.Add("EquipmentDescription", "Descrição do equipamento");
            NotificationDataGridView.Columns.Add("EquipmentStatus", "Status");
            NotificationDataGridView.Columns.Add("EquipmentHandlingStatus", "Tratativa");
            NotificationDataGridView.Columns.Add("EquipmentMaturityDate", "Data de vencimento");

            foreach (var notification in notifications)
            {
                var rowIndex = NotificationDataGridView.Rows.Add();
                var row = NotificationDataGridView.Rows[rowIndex];

                row.Cells["EquipmentId"].Value = notification.Equipment.Id;
                row.Cells["EquipmentCa"].Value = notification.Equipment.Ca;
                row.Cells["EquipmentName"].Value = notification.Equipment.Name;
                row.Cells["EquipmentDescription"].Value = notification.Equipment.Description;
                row.Cells["EquipmentStatus"].Value = notification.Equipment.Status;
                row.Cells["EquipmentHandlingStatus"].Value = notification.Equipment.HandlingStatus;
                row.Cells["EquipmentMaturityDate"].Value = notification.Equipment.MaturityDate?.ToString("dd/MM/yyyy");
            }

            NotificationDataGridView.CellFormatting += MonitorDataGridViewCellColorFormatting;
        }

        private void MonitorDataGridViewCellColorFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (NotificationDataGridView.Columns[e.ColumnIndex].Name == "EquipmentStatus")
            {
                if (e.Value != null && e.Value.ToString() == "Vencido")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }

                if (e.Value != null && e.Value.ToString() == "A vencer")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
