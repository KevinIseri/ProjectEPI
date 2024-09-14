using Microsoft.IdentityModel.Tokens;
using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class EquipmentControl : UserControl
    {
        private DatabaseManager _databaseService;
        private EquipmentService _equipmentService;
        private SectorService _sectorService;

        private readonly List<long> _selectedSectorIds = new();

        public EquipmentControl()
        {
            InitializeComponent();
            FieldEquipmentSectors.ItemCheck += FieldEquipmentSectorsItemCheck;
        }

        public void InitializeServices(DatabaseManager databaseService, EquipmentService equipmentService, SectorService sectorService)
        {
            _databaseService = databaseService;
            _equipmentService = equipmentService;
            _sectorService = sectorService;

            ShowEquipmentsGrid();
            ShowSectorsButton();
        }

        private void ShowSectorsButton()
        {
            FieldEquipmentSectors.Items.Clear();
            FieldEquipmentSectors.Tag = new Dictionary<string, SectorData>();

            var sectors = _sectorService.GetSectors();
            var sectorDictionary = (Dictionary<string, SectorData>)FieldEquipmentSectors.Tag;

            foreach (var sector in sectors)
            {
                FieldEquipmentSectors.Items.Add(sector.Name);
                sectorDictionary[sector.Name] = sector;
            }
        }

        private void ShowEquipmentsGrid()
        {
            var equipments = _equipmentService.GetEquipments();

            EquipmentDataGridView.DataSource = equipments;

            if (!EquipmentDataGridView.Columns.Contains("SectorsDisplay"))
            {
                var sectorsColumn = new DataGridViewTextBoxColumn
                {
                    Name = "SectorsDisplay",
                    HeaderText = "Setores",
                    DataPropertyName = "SectorsDisplay"
                };
                EquipmentDataGridView.Columns.Add(sectorsColumn);
            }

            EquipmentDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            EquipmentDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields())
            {
                var queryInsert = "INSERT INTO public.equipments\r\n(id, ca, description, isactive, \"name\", status, maturity_date,created_date, updated_date) " +
                        "VALUES(nextval('equipments_id_seq'::regclass), @ca, @description, true, @name, @status, @maturitydate, @createdDate, NULL)" +
                        "RETURNING id;";

                long equipmentId = _databaseService.ExecuteScalar<long>(queryInsert, cmd =>
                {
                    cmd.Parameters.AddWithValue("@ca", FieldEquipmentCA.Text);
                    cmd.Parameters.AddWithValue("@description", FieldEquipmentDescription.Text);
                    cmd.Parameters.AddWithValue("@isactive", FieldEquipmentIsActive.Text);
                    cmd.Parameters.AddWithValue("@name", FieldEquipmentName.Text);
                    cmd.Parameters.AddWithValue("@status", FieldEquipmentStatus.Text);
                    cmd.Parameters.AddWithValue("@maturitydate", FieldEquipmentMaturityDate.Value);
                    cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                });

                foreach (var sectorId in _selectedSectorIds)
                {
                    var queryInsertEquipmentSector = "INSERT INTO EquipmentSector (EquipmentId, SectorId) VALUES (@equipmentId, @sectorId);";

                    _databaseService.ExecuteNonQuery(queryInsertEquipmentSector, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                        cmd.Parameters.AddWithValue("@sectorId", sectorId);
                    });
                }

                ShowEquipmentsGrid();
                ClearFields();
                MessageBox.Show("Setor adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields() && ConfirmAction("atualizar", FieldEquipmentId.Text))
            {
                var queryUpdate = "UPDATE public.equipments SET \"name\"=@name, updated_date=@updateDate WHERE id=@id;";

                _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                {
                    cmd.Parameters.AddWithValue("@name", FieldEquipmentName.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", int.Parse(FieldEquipmentId.Text));
                    cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                });

                ShowEquipmentsGrid();
                ClearFields();
                MessageBox.Show("Setor atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearFields()
        {
            FieldEquipmentName.Text = "";
            FieldEquipmentCA.Text = "";
            FieldEquipmentDescription.Text = "";
            FieldEquipmentIsActive.Text = "";
            FieldEquipmentName.Text = "";
            FieldEquipmentStatus.Text = "";
            _selectedSectorIds.Clear(); // nao esta removendo
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {  
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = EquipmentDataGridView.Rows[e.RowIndex];

                FieldEquipmentId.Text = row.Cells["id"].Value.ToString();
                FieldEquipmentName.Text = row.Cells["name"].Value.ToString();
                FieldEquipmentCA.Text = row.Cells["ca"].Value.ToString();
                FieldEquipmentDescription.Text = row.Cells["description"].Value.ToString();
                FieldEquipmentIsActive.Checked = (bool)row.Cells["isactive"].Value;
                FieldEquipmentStatus.Text = row.Cells["status"].Value.ToString();
                //FieldEquipmentSectors.Text = ;
                FieldEquipmentMaturityDate.Value = (DateTime)row.Cells["maturitydate"].Value;

            }
        }

        private void FieldEquipmentSectorsItemCheck(object sender, ItemCheckEventArgs e)
        {
            var sectorDictionary = (Dictionary<string, SectorData>)FieldEquipmentSectors.Tag;
            var sectorName = FieldEquipmentSectors.Items[e.Index].ToString();

            if (sectorDictionary.TryGetValue(sectorName, out var sector))
            {
                long sectorId = sector.Id;
                bool isChecked = e.NewValue == CheckState.Checked;

                if (isChecked)
                {
                    if (!_selectedSectorIds.Contains(sectorId))
                    {
                        _selectedSectorIds.Add(sectorId);
                    }
                }
                else
                {
                    if (_selectedSectorIds.Contains(sectorId))
                    {
                        _selectedSectorIds.Remove(sectorId);
                    }
                }
            }
        }

        private bool ValidadeFilledFields()
        {
            if (FieldEquipmentName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, preencha o campo antes de salvar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        // CommonService
        private static bool ConfirmAction(string action, string id)
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja {action} o Id {id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return confirmation == DialogResult.Yes;
        }
    }
}
