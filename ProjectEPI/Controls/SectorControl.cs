using Microsoft.IdentityModel.Tokens;
using ProjectEPI.Data;
using ProjectEPI.Services;

namespace ProjectEPI.Controls
{
    public partial class SectorControl : UserControl
    {
        private DatabaseManager _databaseService;
        private SectorService _sectorService;

        public SectorControl()
        {
            InitializeComponent();
        }

        public void InitializeServices(DatabaseManager databaseService, SectorService sectorService)
        {
            _databaseService = databaseService;
            _sectorService = sectorService;

            ShowSectorsGrid();
        }

        private void ShowSectorsGrid()
        {
            var sectors = _sectorService.GetSectors();
            SectorDataGridView.DataSource = sectors;
            SectorDataGridView.Columns["Name"].HeaderText = "Nome";
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = SectorDataGridView.Rows[e.RowIndex];

                FieldSectorId.Text = row.Cells["id"].Value.ToString();
                FieldSectorName.Text = row.Cells["name"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            FieldSectorId.Text = "";
            FieldSectorName.Text = "";
        }

        private bool ValidadeFilledFields(bool checkId = false)
        {
            if (checkId && string.IsNullOrEmpty(FieldSectorId.Text))
            {
                MessageBox.Show("Por favor, selecione um setor antes de prosseguir.");
                return false;
            }

            if (FieldSectorName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, preencha o campo antes de salvar.",
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
                try { 
                    var queryInsert = "INSERT INTO public.sectors (id, \"name\", created_date, updated_date) " +
                                      "VALUES(nextval('sectors_id_seq'::regclass), @name, @createdDate, NULL);";

                    _databaseService.ExecuteNonQuery(queryInsert, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@name", FieldSectorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                    });

                    ShowSectorsGrid();
                    ClearFields();
                    MessageBox.Show("Setor adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao adicionar o setor: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("atualizar", FieldSectorId.Text))
            {
                try
                {
                    var queryUpdate = "UPDATE public.sectors SET \"name\"=@name, updated_date=@updateDate WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@name", FieldSectorName.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldSectorId.Text));
                        cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                    });

                    ShowSectorsGrid();
                    ClearFields();
                    MessageBox.Show("Setor atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar o setor: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields(checkId: true) && ConfirmAction("deletar", FieldSectorId.Text))
            {
                try
                {
                    var queryDelete = "DELETE FROM public.sectors WHERE id=@id;";

                    _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                    {
                        cmd.Parameters.AddWithValue("@id", long.Parse(FieldSectorId.Text));
                    });

                    ShowSectorsGrid();
                    ClearFields();
                    MessageBox.Show("Setor deletado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao deletar o setor: {ex.Message}", 
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
