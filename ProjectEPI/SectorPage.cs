using Microsoft.IdentityModel.Tokens;
using Npgsql;
using System.Configuration;
using System.Data;

namespace ProjectEPI
{
    public partial class SectorPage : Form
    {
        //NpgsqlConnection conn = new(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();

        public SectorPage()
        {
            InitializeComponent();

            ShowSectorsGrid();
        }

        public void ShowSectorsGrid()
        {
            SectorData sd = new();
            List<SectorData> sectors = sd.GetSectors();

            DataGridViewSectors.DataSource = sectors;
        }

        private void DataGridViewSectorsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridViewSectors.Rows[e.RowIndex];

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

                ExecuteNonQuery(queryInsert, cmd =>
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

                ExecuteNonQuery(queryUpdate, cmd =>
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

                ExecuteNonQuery(queryDelete, cmd =>
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

        private void ExecuteNonQuery(string query, Action<NpgsqlCommand> parameterize)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        parameterize(cmd);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
