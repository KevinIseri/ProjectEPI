using Microsoft.IdentityModel.Tokens;
using ProjectEPI.Constants;
using ProjectEPI.Data;
using ProjectEPI.Data.Dtos;
using ProjectEPI.Services;
using static ProjectEPI.Constants.EquipmentConstants;

namespace ProjectEPI.Forms
{
    public partial class EquipmentModal : Form
    {
        private readonly EquipmentDto _equipment;
        private readonly DatabaseManager _databaseService;
        private readonly Action _refreshMonitorGrid;
        private readonly SectorService _sectorService;
        private readonly string? _sectors;
        private readonly string _modalType;

        private readonly List<long> _selectedSectorIds = [];

        public EquipmentModal(
            EquipmentDto equipment,
            Action refreshMonitorGrid,
            DatabaseManager databaseService,
            SectorService setorService,
            string modalType,
            string? sectors
            )
        {
            InitializeComponent();
            FieldEquipmentSectors.ItemCheck += FieldEquipmentSectorsItemCheck;

            _equipment = equipment;
            _refreshMonitorGrid = refreshMonitorGrid;
            _databaseService = databaseService;
            _modalType = modalType;
            _sectorService = setorService;
            _sectors = sectors;

            ClearSelectedSectors();

            if (_modalType == ModalConstants.Type.EDIT)
            {
                FieldEquipmentModalId.Text = _equipment.Id.ToString();
                FieldEquipmentModalName.Text = _equipment.Name;
                FieldEquipmentModalCA.Text = _equipment.Ca;
                FieldEquipmentModalDescription.Text = _equipment.Description;
                FieldEquipmentModalStatus.Text = _equipment.Status;
                FieldEquipmentModalIsActive.Checked = _equipment.IsActive;
                FieldEquipmentModalMaturityDate.Value = _equipment.MaturityDate.Value;

                ButtonAdd.Visible = false;
            }

            if (_modalType == ModalConstants.Type.ADD)
            {
                ButtonUpdate.Visible = false;
                ButtonDelete.Visible = false;
            }

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
            FieldEquipmentModalId.Text = "";
            FieldEquipmentModalName.Text = "";
            FieldEquipmentModalCA.Text = "";
            FieldEquipmentModalDescription.Text = "";
            FieldEquipmentModalIsActive.Checked = false;
            FieldEquipmentModalName.Text = "";
            FieldEquipmentModalStatus.Text = "";

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
            if (checkId && string.IsNullOrEmpty(FieldEquipmentModalId.Text))
            {
                MessageBox.Show("Por favor, selecione um setor antes de prosseguir.");
                return false;
            }

            if (FieldEquipmentModalName.Text.IsNullOrEmpty() ||
                FieldEquipmentModalCA.Text.IsNullOrEmpty() ||
                FieldEquipmentModalStatus.Text.IsNullOrEmpty() ||
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
                        cmd.Parameters.AddWithValue("@ca", FieldEquipmentModalCA.Text);
                        cmd.Parameters.AddWithValue("@description", FieldEquipmentModalDescription.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldEquipmentModalIsActive.Checked);
                        cmd.Parameters.AddWithValue("@name", FieldEquipmentModalName.Text);
                        cmd.Parameters.AddWithValue("@status", FieldEquipmentModalStatus.Text);
                        cmd.Parameters.AddWithValue("@handling_status", HandlingStatus.NONE);
                        cmd.Parameters.AddWithValue("@maturitydate", FieldEquipmentModalMaturityDate.Value);
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
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("atualizar", FieldEquipmentModalId.Text))
            {
                try
                {
                    long equipmentId = long.Parse(FieldEquipmentModalId.Text);

                    var queryUpdate = "UPDATE public.equipments " +
                                      "SET ca = @ca, description = @description, isactive = @isactive, name = @name, status = @status, " +
                                      "maturity_date = @maturitydate, updated_date = @updatedDate " +
                                      "WHERE id = @equipmentId;";

                    _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@equipmentId", equipmentId);
                        cmd.Parameters.AddWithValue("@ca", FieldEquipmentModalCA.Text);
                        cmd.Parameters.AddWithValue("@description", FieldEquipmentModalDescription.Text);
                        cmd.Parameters.AddWithValue("@isactive", FieldEquipmentModalIsActive.Checked);
                        cmd.Parameters.AddWithValue("@name", FieldEquipmentModalName.Text);
                        cmd.Parameters.AddWithValue("@status", FieldEquipmentModalStatus.Text);
                        cmd.Parameters.AddWithValue("@maturitydate", FieldEquipmentModalMaturityDate.Value);
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
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("deletar", FieldEquipmentModalId.Text))
            {
                try
                {
                    var queryDelete = "DELETE FROM public.equipments WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldEquipmentModalId.Text));
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

        private void PictureBoxCloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
