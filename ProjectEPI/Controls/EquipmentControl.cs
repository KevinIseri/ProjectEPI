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

            var sectors = _sectorService.GetSectors();

            var sectorDictionary = new Dictionary<string, SectorData>();

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
            foreach (var item in FieldEquipmentSectors.CheckedItems)
            {
                Console.WriteLine($"Item selecionado: {item}");
            }

            if (ValidadeFilledFields())
            {
                var queryInsert = "INSERT INTO public.equipments\r\n(id, ca, description, isactive, \"name\", status, maturity_date, created_date, updated_date) " +
                        "VALUES(nextval('equipments_id_seq'::regclass), @ca, @description, true, @name, @status, @maturitydate, @created_date, NULL);";

                _databaseService.ExecuteNonQuery(queryInsert, cmd =>
                {
                    cmd.Parameters.AddWithValue("@name", FieldEquipmentName.Text.Trim());
                    cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                });

                ShowEquipmentsGrid();
                ClearFields();
                MessageBox.Show("Setor adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ClearFields()
        {
            FieldEquipmentName.Text = "";
        }

        private void FieldEquipmentSectorsItemCheck(object sender, ItemCheckEventArgs e)
        {
            string sectorName = FieldEquipmentSectors.Items[e.Index].ToString();
            bool isChecked = e.NewValue == CheckState.Checked;

            if (isChecked)
            {
                Console.WriteLine($"Setor marcado: {sectorName}");
            }
            else
            {
                Console.WriteLine($"Setor desmarcado: {sectorName}");
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
