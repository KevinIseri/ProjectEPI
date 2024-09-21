using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Forms;
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

            if (e.RowIndex >= 0 && MonitorDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = MonitorDataGridView.Rows[e.RowIndex];

                MonitorEditModal editModal = new(
                    new EquipmentDto
                    {
                        Id = (long)row.Cells["Id"].Value,
                        Ca = row.Cells["Ca"].Value.ToString(),
                        Description = row.Cells["Description"].Value.ToString(),
                        IsActive = (bool)row.Cells["IsActive"].Value,
                        HandlingStatus = row.Cells["HandlingStatus"].Value.ToString()
                    }
                );

                editModal.ShowDialog();

            }
        }
    }
}
