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

        public MainPage()
        {
            InitializeComponent();

            _databaseManager = new DatabaseManager();
            _equipmentService = new EquipmentService(_databaseManager);
            _sectorService = new SectorService(_databaseManager);
            _settingService = new SettingService(_databaseManager);
            _notificationService = new NotificationService(_databaseManager, _equipmentService, _settingService);

            equipmentControl1.InitializeServices(_databaseManager, _equipmentService, _sectorService);
            monitorControl1.InitializeServices(_databaseManager, _equipmentService);
            sectorControl1.InitializeServices(_databaseManager, _sectorService);

            equipmentControl1.Visible = false;
            monitorControl1.Visible = true;
            sectorControl1.Visible = false;

            _notificationService.GenerateNotifications();
        }

        private void SectorsButtonClick(object sender, EventArgs e)
        {
            sectorControl1.ShowSectorsGrid();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = false;
            sectorControl1.Visible = true;
        }

        private void EquipmentsButtonClick(object sender, EventArgs e)
        {
            equipmentControl1.ShowSectorsButton();
            sectorControl1.ShowSectorsGrid();

            equipmentControl1.Visible = true;
            monitorControl1.Visible = false;
            sectorControl1.Visible = false;
        }

        private void MonitorButtonClick(object sender, EventArgs e)
        {
            monitorControl1.ShowMonitorGrid();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = true;
            sectorControl1.Visible = false;
        }

        private void NotificationsButtonClick(object sender, EventArgs e)
        {
            //monitorControl1.ShowMonitorGrid();

            equipmentControl1.Visible = false;
            monitorControl1.Visible = false;
            sectorControl1.Visible = false;
            // notificationControl1.Visible = true;
        }
    }
}
