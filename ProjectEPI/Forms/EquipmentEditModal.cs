using Microsoft.IdentityModel.Tokens;
using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Services;
using static ProjectEPI.Constants.EquipmentConstants;

namespace ProjectEPI.Forms
{
    public partial class EquipmentEditModal : Form
    {
        private readonly EquipmentDto _equipment;
        private readonly DatabaseManager _databaseService;
        private readonly Action _refreshMonitorGrid;
        private readonly SectorService _sectorService;
        private readonly string? _sectors;

        private readonly List<long> _selectedSectorIds = [];

        public EquipmentEditModal(
            EquipmentDto equipment,
            DatabaseManager databaseService,
            Action refreshMonitorGrid,
            SectorService setorService,
            string? sectors)
        {
            InitializeComponent();
            FieldEquipmentSectors.ItemCheck += FieldEquipmentSectorsItemCheck;

            _equipment = equipment;
            _databaseService = databaseService;
            _refreshMonitorGrid = refreshMonitorGrid;
            _sectorService = setorService;
            _sectors = sectors;

            FieldEquipmentEditModalId.Text = _equipment.Id.ToString();
            FieldEquipmenttEditModalName.Text = _equipment.Name;
            FieldEquipmenttEditModalCA.Text = _equipment.Ca;
            FieldEquipmenttEditModalDescription.Text = _equipment.Description;
            FieldEquipmenttEditModalStatus.Text = _equipment.Status;
            FieldEquipmenttEditModalIsActive.Checked = _equipment.IsActive;
            FieldEquipmenttEditModalMaturityDate.Value = _equipment.MaturityDate.Value;

            ClearSelectedSectors();
            ShowSectorsButton();

            if (_sectors != null)
            {
                var sectorNames = _sectors.Split(',');
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

        private void EquipmentEditModal_Load(object sender, EventArgs e)
        {

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

        private void ClearFields()
        {
            FieldEquipmentEditModalId.Text = "";
            FieldEquipmenttEditModalName.Text = "";
            FieldEquipmenttEditModalCA.Text = "";
            FieldEquipmenttEditModalDescription.Text = "";
            FieldEquipmenttEditModalIsActive.Checked = false;
            FieldEquipmenttEditModalName.Text = "";
            FieldEquipmenttEditModalStatus.Text = "";

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

        private bool ValidadeFilledFields(bool checkId = false)
        {
            if (checkId && string.IsNullOrEmpty(FieldEquipmentEditModalId.Text))
            {
                MessageBox.Show("Por favor, selecione um setor antes de prosseguir.");
                return false;
            }

            if (FieldEquipmenttEditModalName.Text.IsNullOrEmpty() ||
                FieldEquipmenttEditModalCA.Text.IsNullOrEmpty() ||
                FieldEquipmenttEditModalStatus.Text.IsNullOrEmpty() ||
                _selectedSectorIds.Count == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private static bool ConfirmAction(string action, string id)
        {
            var confirmation = MessageBox.Show($"Tem certeza que deseja {action} o Id {id}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return confirmation == DialogResult.Yes;
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields())
            {
                try
                {
                    var queryInsert = "INSERT INTO public.equipments\r\n(id, ca, description, isactive, \"name\", status, handling_status, maturity_date, created_date, updated_date) " +
                            "VALUES(nextval('equipments_id_seq'::regclass), @ca, @description, true, @name, @status, @handling_status, @maturitydate, @createdDate, NULL)" +
                            "RETURNING id;";

                    long equipmentId = _databaseService.ExecuteScalar<long>(queryInsert, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@ca", FieldEquipmenttEditModalCA.Text);
                        cmd.Parameters.AddWithValue("@description", FieldEquipmenttEditModalDescription.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldEquipmenttEditModalIsActive.Checked);
                        cmd.Parameters.AddWithValue("@name", FieldEquipmenttEditModalName.Text);
                        cmd.Parameters.AddWithValue("@status", FieldEquipmenttEditModalStatus.Text);
                        cmd.Parameters.AddWithValue("@handling_status", HandlingStatus.NONE);
                        cmd.Parameters.AddWithValue("@maturitydate", FieldEquipmenttEditModalMaturityDate.Value);
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

                    _refreshMonitorGrid();
                    ClearFields();
                    MessageBox.Show("Equipamento adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("atualizar", FieldEquipmentEditModalId.Text))
            {
                try
                {
                    long equipmentId = long.Parse(FieldEquipmentEditModalId.Text);

                    var queryUpdate = "UPDATE public.equipments " +
                                      "SET ca = @ca, description = @description, isactive = @isactive, name = @name, status = @status, " +
                                      "maturity_date = @maturitydate, updated_date = @updatedDate " +
                                      "WHERE id = @equipmentId;";

                    _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                        cmd.Parameters.AddWithValue("@ca", FieldEquipmenttEditModalCA.Text);
                        cmd.Parameters.AddWithValue("@description", FieldEquipmenttEditModalDescription.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldEquipmenttEditModalIsActive.Checked);
                        cmd.Parameters.AddWithValue("@name", FieldEquipmenttEditModalName.Text);
                        cmd.Parameters.AddWithValue("@status", FieldEquipmenttEditModalStatus.Text);
                        cmd.Parameters.AddWithValue("@maturitydate", FieldEquipmenttEditModalMaturityDate.Value);
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

                    _refreshMonitorGrid();
                    ClearFields();
                    MessageBox.Show("Equipamento atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("deletar", FieldEquipmentEditModalId.Text))
            {
                try
                {
                    var queryDelete = "DELETE FROM public.equipments WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldEquipmentEditModalId.Text));
                    });

                    _refreshMonitorGrid();
                    ClearFields();
                    MessageBox.Show("Equipamento deletado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
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
