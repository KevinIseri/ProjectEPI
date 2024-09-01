using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class EquipmentControl : UserControl
    {
        private DatabaseManager _databaseService;
        private SectorService _sectorService;

        public EquipmentControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(DatabaseManager databaseService, SectorService sectorService)
        {
            _databaseService = databaseService;
            _sectorService = sectorService;

            //ShowEquipmentsGrid();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
