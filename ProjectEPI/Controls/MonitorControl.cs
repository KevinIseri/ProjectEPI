using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class MonitorControl : UserControl
    {
        private DatabaseManager _databaseService;
        private EquipmentService _equipmentService;

        public MonitorControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(DatabaseManager databaseService, EquipmentService equipmentService)
        {
            _databaseService = databaseService;
            _equipmentService = equipmentService;

            //ShowEquipmentsGrid();
            //ShowSectorsButton();
        }
    }
}
