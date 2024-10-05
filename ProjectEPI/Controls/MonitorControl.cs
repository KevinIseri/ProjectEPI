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
        private NotificationService _notificationService;

        public MonitorControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(
            DatabaseManager databaseService, 
            EquipmentService equipmentService,
            NotificationService notificationService)
        {
            _databaseService = databaseService;
            _equipmentService = equipmentService;
            _notificationService = notificationService;

            ShowMonitorGrid();
        }

        public void ShowMonitorGrid()
        {
            var equipments = _equipmentService.GetEquipments("maturity_date", "ASC", true);

            MonitorDataGridView.DataSource = equipments;

            MonitorDataGridView.Columns["Edit"].DisplayIndex = MonitorDataGridView.Columns.Count - 1;

            MonitorDataGridView.Columns["Name"].HeaderText = "Nome";
            MonitorDataGridView.Columns["Ca"].HeaderText = "CA";
            MonitorDataGridView.Columns["Description"].HeaderText = "Descrição";
            MonitorDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            MonitorDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";
            MonitorDataGridView.Columns["HandlingStatus"].HeaderText = "Tratativa";

            MonitorDataGridView.Columns["IsActive"].Visible = false;

            MonitorDataGridView.Columns["MaturityDate"].DefaultCellStyle.Format = "d";

            MonitorDataGridView.CellFormatting += MonitorDataGridViewCellColorFormatting;
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && MonitorDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = MonitorDataGridView.Rows[e.RowIndex];

                MonitorEditModal editModal = new(
                    new EquipmentDto
                    {
                        Id = (long)row.Cells["Id"].Value,
                        Ca = row.Cells["Ca"].Value.ToString(),
                        Description = row.Cells["Description"].Value.ToString(),
                        Name = row.Cells["Name"].Value.ToString(),
                        IsActive = (bool)row.Cells["IsActive"].Value,
                        HandlingStatus = row.Cells["HandlingStatus"].Value.ToString(),
                        MaturityDate = (DateTime?)row.Cells["MaturityDate"].Value
                    },
                    _databaseService, 
                    ShowMonitorGrid,
                    _notificationService
                );

                editModal.ShowDialog();
            }
        }

        private void MonitorDataGridViewCellColorFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (MonitorDataGridView.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null && e.Value.ToString() == "Vencido")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }

                if (e.Value != null && e.Value.ToString() == "A vencer")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
