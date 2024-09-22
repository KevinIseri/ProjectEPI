using ProjectEPI.Data;
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

            NotificationDataGridView.DataSource = notifications;
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //DataGridViewRow row = SectorDataGridView.Rows[e.RowIndex];

                //FieldSectorId.Text = row.Cells["id"].Value.ToString();
                //FieldSectorName.Text = row.Cells["name"].Value.ToString();

            }
        }
    }
}
