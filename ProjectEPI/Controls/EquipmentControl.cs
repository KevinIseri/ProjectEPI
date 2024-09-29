using Microsoft.IdentityModel.Tokens;
using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Forms;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class EquipmentControl : UserControl
    {
        private DatabaseManager _databaseService;
        private EquipmentService _equipmentService;
        private SectorService _sectorService;

        private readonly List<long> _selectedSectorIds = [];

        public EquipmentControl()
        {
            InitializeComponent();
            //FieldEquipmentSectors.ItemCheck += FieldEquipmentSectorsItemCheck;
        }

        public void InitializeServices(DatabaseManager databaseService, EquipmentService equipmentService, SectorService sectorService)
        {
            _databaseService = databaseService;
            _equipmentService = equipmentService;
            _sectorService = sectorService;

            ShowEquipmentsGrid();
            //ShowSectorsButton();
        }


        private void ShowEquipmentsGrid()
        {
            var equipments = _equipmentService.GetEquipments();

            EquipmentDataGridView.DataSource = equipments;

            EquipmentDataGridView.Columns["Edit"].DisplayIndex = EquipmentDataGridView.Columns.Count - 1;

            EquipmentDataGridView.Columns["Name"].HeaderText = "Nome";
            EquipmentDataGridView.Columns["Ca"].HeaderText = "CA";
            EquipmentDataGridView.Columns["IsActive"].HeaderText = "Ativo";
            EquipmentDataGridView.Columns["Description"].HeaderText = "Descrição";
            EquipmentDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            EquipmentDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";

            EquipmentDataGridView.Columns["HandlingStatus"].Visible = false;

            EquipmentDataGridView.Columns["MaturityDate"].DefaultCellStyle.Format = "d";
        }

        //private void ClearFields()
        //{
        //    FieldEquipmentId.Text = "";
        //    FieldEquipmentName.Text = "";
        //    FieldEquipmentCA.Text = "";
        //    FieldEquipmentDescription.Text = "";
        //    FieldEquipmentIsActive.Checked = false;
        //    FieldEquipmentName.Text = "";
        //    FieldEquipmentStatus.Text = "";

        //    ClearSelectedSectors();
        //}

        //private void ClearSelectedSectors()
        //{
        //    _selectedSectorIds.Clear();

        //    foreach (int index in FieldEquipmentSectors.CheckedIndices)
        //    {
        //        FieldEquipmentSectors.SetItemChecked(index, false);
        //    }
        //}

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && EquipmentDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow row = EquipmentDataGridView.Rows[e.RowIndex];
                
                var sectors = row.Cells["SectorsDisplay"].Value as string;

                EquipmentEditModal editModal = new(
                    new EquipmentDto
                    {
                        Id = (long)row.Cells["Id"].Value,
                        Name = row.Cells["name"].Value.ToString(),
                        Ca = row.Cells["ca"].Value.ToString(),
                        Description = row.Cells["description"].Value.ToString(),
                        IsActive = (bool)row.Cells["IsActive"].Value,
                        Status = row.Cells["status"].Value.ToString(),
                        MaturityDate = (DateTime)row.Cells["maturitydate"].Value
                    }, 
                    _databaseService,
                    ShowEquipmentsGrid, 
                    _sectorService,
                    sectors
                );

                editModal.ShowDialog();
            }
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
        }
    }
}
