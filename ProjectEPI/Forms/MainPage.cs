using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI
{
    public partial class MainPage : Form
    {
        private DatabaseManager _databaseManager;
        private EquipmentService _equipmentService;
        private SectorService _sectorService;

        public MainPage()
        {
            InitializeComponent();

            _databaseManager = new DatabaseManager();
            _equipmentService = new EquipmentService(_databaseManager);
            _sectorService = new SectorService(_databaseManager);

            equipmentControl1.InitializeServices(_databaseManager, _equipmentService, _sectorService);
            monitorControl1.InitializeServices(_databaseManager, _equipmentService);
            sectorControl1.InitializeServices(_databaseManager, _sectorService);

            equipmentControl1.Visible = false;
            monitorControl1.Visible = true;
            sectorControl1.Visible = false;
        }

        private void SectorsButtonClick(object sender, EventArgs e)
        {
            equipmentControl1.Visible = false;
            monitorControl1.Visible = false;
            sectorControl1.Visible = true;
        }

        private void EquipmentsButtonClick(object sender, EventArgs e)
        {
            equipmentControl1.Visible = true;
            monitorControl1.Visible = false;
            sectorControl1.Visible = false;
        }

        private void MonitorButtonClick(object sender, EventArgs e)
        {
            equipmentControl1.Visible = false;
            monitorControl1.Visible = true;
            sectorControl1.Visible = false;
        }
    }
}
