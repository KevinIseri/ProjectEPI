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

        public void ShowSectorsGrid()
        {
            List<SectorData> sectors = _sectorService.GetSectors();
            dataGridView1.DataSource = sectors;
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                TextBoxId.Text = row.Cells[0].Value.ToString();
                TextBoxName.Text = row.Cells[1].Value.ToString();
            }
        }

        public void ClearFields()
        {
            TextBoxId.Text = "";
            TextBoxName.Text = "";
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields())
            {
                var queryInsert = "INSERT INTO public.sectors (id, \"name\", created_date, updated_date) " +
                                  "VALUES(nextval('sectors_id_seq'::regclass), @name, @createdDate, NULL);";

                _databaseService.ExecuteNonQuery(queryInsert, cmd =>
                {
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text.Trim());
                    cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                });

                ShowSectorsGrid();
                ClearFields();
                MessageBox.Show("Setor adicionado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields() && ConfirmAction("atualizar", TextBoxId.Text))
            {
                var queryUpdate = "UPDATE public.sectors SET \"name\"=@name, updated_date=@updateDate WHERE id=@id;";

                _databaseService.ExecuteNonQuery(queryUpdate, cmd =>
                {
                    cmd.Parameters.AddWithValue("@name", TextBoxName.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", int.Parse(TextBoxId.Text));
                    cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);
                });

                ShowSectorsGrid();
                ClearFields();
                MessageBox.Show("Setor atualizado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields() && ConfirmAction("deletar", TextBoxId.Text))
            {
                var queryDelete = "DELETE FROM public.sectors WHERE id=@id;";

                _databaseService.ExecuteNonQuery(queryDelete, cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(TextBoxId.Text));
                });

                ShowSectorsGrid();
                ClearFields();
                MessageBox.Show("Setor deletado com sucesso!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool ValidadeFilledFields()
        {
            if (TextBoxName.Text.IsNullOrEmpty())
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
    }
}
