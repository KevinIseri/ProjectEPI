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

        public void ShowSectorsButton()
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

            EquipmentDataGridView.Columns["Name"].HeaderText = "Nome";
            EquipmentDataGridView.Columns["Ca"].HeaderText = "CA";
            EquipmentDataGridView.Columns["IsActive"].HeaderText = "Ativo";
            EquipmentDataGridView.Columns["Description"].HeaderText = "Descrição";
            EquipmentDataGridView.Columns["MaturityDate"].HeaderText = "Vencimento";
            EquipmentDataGridView.Columns["SectorsDisplay"].HeaderText = "Setores";

            EquipmentDataGridView.Columns["HandlingStatus"].Visible = false;
        }

        private void ClearFields()
        {
            FieldEquipmentId.Text = "";
            FieldEquipmentName.Text = "";
            FieldEquipmentCA.Text = "";
            FieldEquipmentDescription.Text = "";
            FieldEquipmentIsActive.Checked = false;
            FieldEquipmentName.Text = "";
            FieldEquipmentStatus.Text = "";

            ClearSelectedSectors();
        }

        private void ClearSelectedSectors()
        {
            _selectedSectorIds.Clear();

            foreach (int index in FieldEquipmentSectors.CheckedIndices)
            {
                FieldEquipmentSectors.SetItemChecked(index, false);
            }
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
                FieldEquipmentMaturityDate.Value = (DateTime)row.Cells["maturitydate"].Value;

                var sectors = row.Cells["SectorsDisplay"].Value as string;

                ClearSelectedSectors();

                if (sectors != null)
                {
                    var sectorNames = sectors.Split(',');
                    foreach (string sectorName in sectorNames)
                    {
                        for (int i = 0; i < FieldEquipmentSectors.Items.Count; i++)
                        {
                            if (FieldEquipmentSectors.Items[i].ToString() == sectorName.Trim())
                            {
                                FieldEquipmentSectors.SetItemChecked(i, true);
                            }
                        }
                    }
                }
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

        private bool ValidadeFilledFields(bool checkId = false)
        {
            if (checkId && string.IsNullOrEmpty(FieldEquipmentId.Text))
            {
                MessageBox.Show("Por favor, selecione um setor antes de prosseguir.");
                return false;
            }

            if (FieldEquipmentName.Text.IsNullOrEmpty() ||
                FieldEquipmentCA.Text.IsNullOrEmpty() ||
                FieldEquipmentStatus.Text.IsNullOrEmpty() ||
                _selectedSectorIds.Count == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar.",
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

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields())
            {
                try { 
                    var queryInsert = "INSERT INTO public.equipments\r\n(id, ca, description, isactive, \"name\", status, maturity_date,created_date, updated_date) " +
                            "VALUES(nextval('equipments_id_seq'::regclass), @ca, @description, true, @name, @status, @maturitydate, @createdDate, NULL)" +
                            "RETURNING id;";

                    long equipmentId = _databaseService.ExecuteScalar<long>(queryInsert, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@ca", FieldEquipmentCA.Text);
                        cmd.Parameters.AddWithValue("@description", FieldEquipmentDescription.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldEquipmentIsActive.Checked);
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
                    MessageBox.Show("Equipamento adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar o equipamento: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("atualizar", FieldEquipmentId.Text))
            {
                try
                {
                    long equipmentId = long.Parse(FieldEquipmentId.Text);

                    var queryUpdate = "UPDATE public.equipments " +
                                      "SET ca = @ca, description = @description, isactive = @isactive, name = @name, status = @status, " +
                                      "maturity_date = @maturitydate, updated_date = @updatedDate " +
                                      "WHERE id = @equipmentId;";

                    _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                        cmd.Parameters.AddWithValue("@ca", FieldEquipmentCA.Text);
                        cmd.Parameters.AddWithValue("@description", FieldEquipmentDescription.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldEquipmentIsActive.Checked);
                        cmd.Parameters.AddWithValue("@name", FieldEquipmentName.Text);
                        cmd.Parameters.AddWithValue("@status", FieldEquipmentStatus.Text);
                        cmd.Parameters.AddWithValue("@maturitydate", FieldEquipmentMaturityDate.Value);
                        cmd.Parameters.AddWithValue("@updatedDate", DateTime.Now);
                    });

                    var queryDeleteSectors = "DELETE FROM EquipmentSector WHERE EquipmentId = @equipmentId;";
                    _databaseService.ExecuteNonQuery(queryDeleteSectors, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
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
                    MessageBox.Show("Equipamento atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o equipamento: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("deletar", FieldEquipmentId.Text))
            {
                try
                {
                    var queryDelete = "DELETE FROM public.equipments WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldEquipmentId.Text));
                    });

                    ShowEquipmentsGrid();
                    ClearFields();
                    MessageBox.Show("Equipamento deletado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao deletar o equipamento: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
