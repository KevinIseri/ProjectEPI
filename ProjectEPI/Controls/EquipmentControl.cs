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

        private List<long> _selectedSectorIds = new List<long>();

        public EquipmentControl()
        {
            InitializeComponent();
            FieldEquipmentSectors.ItemCheck += FieldEquipmentSectorsItemCheck;
        }

        public void InitializeServices(DatabaseManager databaseService, EquipmentService equipmentService,SectorService sectorService)
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
            var sectors = _equipmentService.GetEquipments();
            EquipmentDataGridView.DataSource = sectors;
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

        private void ClearFields()
        {
            FieldEquipmentName.Text = "";
            _selectedSectorIds.Clear();
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

    }
}
