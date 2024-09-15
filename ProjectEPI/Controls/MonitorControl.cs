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

            ShowMonitorGrid();
        }

        private void ShowMonitorGrid()
        {
            var equipments = _equipmentService.GetEquipments();

            MonitorDataGridView.DataSource = equipments;

            if (!MonitorDataGridView.Columns.Contains("SectorsDisplay"))
            {
                var sectorsColumn = new DataGridViewTextBoxColumn
                {
                    Name = "SectorsDisplay",
                    HeaderText = "SectorsDisplay",
                    DataPropertyName = "SectorsDisplay"
                };
                MonitorDataGridView.Columns.Add(sectorsColumn);
            }

            //MonitorDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            //MonitorDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";
        }
    }
}
