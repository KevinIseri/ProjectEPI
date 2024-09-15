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

        public void ShowMonitorGrid()
        {
            var equipments = _equipmentService.GetEquipments();

            MonitorDataGridView.DataSource = equipments;

            //MonitorDataGridView.Columns["Id"].DisplayIndex = 0;
            //MonitorDataGridView.Columns["Name"].DisplayIndex = 1;
            //MonitorDataGridView.Columns["Ca"].DisplayIndex = 2;
            //MonitorDataGridView.Columns["Description"].DisplayIndex = 3;
            //MonitorDataGridView.Columns["IsActive"].DisplayIndex = 4;
            //MonitorDataGridView.Columns["Status"].DisplayIndex = 5;
            //MonitorDataGridView.Columns["MaturityDate"].DisplayIndex = 6;
            //MonitorDataGridView.Columns["HandlingStatus"].DisplayIndex = 7;
            //MonitorDataGridView.Columns["SectorsDisplay"].DisplayIndex = 8;
            MonitorDataGridView.Columns["Edit"].DisplayIndex = MonitorDataGridView.Columns.Count - 1;

            MonitorDataGridView.Columns["Name"].HeaderText = "Nome";
            MonitorDataGridView.Columns["Ca"].HeaderText = "CA";
            MonitorDataGridView.Columns["IsActive"].HeaderText = "Ativo";
            MonitorDataGridView.Columns["Description"].HeaderText = "Descrição";
            MonitorDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            MonitorDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";
            MonitorDataGridView.Columns["HandlingStatus"].HeaderText = "Tratativa";
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
