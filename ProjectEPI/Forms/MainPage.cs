using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI
{
    public partial class MainPage : Form
    {
        private readonly DatabaseManager _databaseManager;
        private readonly EquipmentService _equipmentService;
        private readonly NotificationService _notificationService;
        private readonly SectorService _sectorService;
        private readonly SettingService _settingService;

        private Point MOUSE_LOCATION;

        public MainPage()
        {
            InitializeComponent();

            _databaseManager = new DatabaseManager();
            _equipmentService = new EquipmentService(_databaseManager);
            _sectorService = new SectorService(_databaseManager);
            _settingService = new SettingService(_databaseManager);
            _notificationService = new NotificationService(_databaseManager, _equipmentService, _settingService, LabelMainNotificationNumber);

            equipmentControl1.InitializeServices(_databaseManager, _equipmentService, _sectorService);
            monitorControl1.InitializeServices(_databaseManager, _equipmentService, _notificationService, _settingService);
            sectorControl1.InitializeServices(_databaseManager, _sectorService);
            notificationControl1.InitializeServices(_notificationService);
            settingControl1.InitializeServices(_settingService, _databaseManager);

            equipmentControl1.Visible = false;
            monitorControl1.Visible = true;
            sectorControl1.Visible = false;
            notificationControl1.Visible = false;
            settingControl1.Visible = false;

            _notificationService.GenerateNotifications();
        }

        private void SectorsButtonClick(object sender, EventArgs e)
        {
            sectorControl1.ShowSectorsGrid();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = false;
            sectorControl1.Visible = true;
            notificationControl1.Visible = false;
            settingControl1.Visible = false;
        }

        private void EquipmentsButtonClick(object sender, EventArgs e)
        {
            sectorControl1.ShowSectorsGrid();

            equipmentControl1.Visible = true;
            monitorControl1.Visible = false;
            sectorControl1.Visible = false;
            notificationControl1.Visible = false;
            settingControl1.Visible = false;
        }

        private void MonitorButtonClick(object sender, EventArgs e)
        {
            _notificationService.GenerateNotifications();

            monitorControl1.ShowMonitorGrid();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = true;
            sectorControl1.Visible = false;
            notificationControl1.Visible = false;
            settingControl1.Visible = false;
        }

        private void NotificationsButtonClick(object sender, EventArgs e)
        {
            _notificationService.GenerateNotifications();
            notificationControl1.ShowNotificationGrid();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = false;
            sectorControl1.Visible = false;
            notificationControl1.Visible = true;
            settingControl1.Visible = false;
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            settingControl1.FillSettingFields();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = false;
            sectorControl1.Visible = false;
            notificationControl1.Visible = false;
            settingControl1.Visible = true;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            MOUSE_LOCATION = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(MOUSE_LOCATION.X, MOUSE_LOCATION.Y);
                Location = mousePosition;
            }
        }

        private void PictureBoxMinimizeButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxCloseButtonClick(object sender, EventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show("Deseja sair do aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
