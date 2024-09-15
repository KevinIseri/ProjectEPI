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
                    HeaderText = "Setores",
                    DataPropertyName = "SectorsDisplay"
                };
                MonitorDataGridView.Columns.Add(sectorsColumn);
            }

            MonitorDataGridView.Columns["Name"].HeaderText = "Nome";
            MonitorDataGridView.Columns["Ca"].HeaderText = "CA";
            MonitorDataGridView.Columns["IsActive"].HeaderText = "Ativo";
            MonitorDataGridView.Columns["Description"].HeaderText = "Descrição";
            MonitorDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            MonitorDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";
            MonitorDataGridView.Columns["HandlingStatus"].HeaderText = "Tratativa";

            MonitorDataGridView.Columns["Id"].DisplayIndex = 0;
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = MonitorDataGridView.Rows[e.RowIndex];
                //row.Cells["id"]
            }
        }
    }
}
