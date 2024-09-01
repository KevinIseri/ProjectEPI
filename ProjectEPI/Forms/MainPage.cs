using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI
{
    public partial class MainPage : Form
    {
        private DatabaseManager _databaseManager;
        private SectorService _sectorService;

        public MainPage()
        {
            InitializeComponent();

            _databaseManager = new DatabaseManager();
            _sectorService = new SectorService(_databaseManager);

            sectorControl1.InitializeServices(_databaseManager, _sectorService);
            equipmentControl1.InitializeServices(_databaseManager, _sectorService);

            sectorControl1.Visible = false;
            equipmentControl1.Visible = false;
        }

        private void SectorsButtonClick(object sender, EventArgs e)
        {
            sectorControl1.Visible = true;
            equipmentControl1.Visible = false;
        }

        private void EquipmentsButtonClick(object sender, EventArgs e)
        {
            sectorControl1.Visible = false;
            equipmentControl1.Visible = true;
        }
    }
}
