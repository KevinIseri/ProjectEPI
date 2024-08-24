using Microsoft.IdentityModel.Tokens;
using Npgsql;
using System.Configuration;
using System.Data;

namespace ProjectEPI
{
    public partial class SectorPage : Form
    {
        NpgsqlConnection conn = new(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

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
            if (TextBoxName.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, preencha o campo antes de salvar.",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        var queryInsert = "INSERT INTO public.sectors (id, \"name\", created_date, updated_date) " +
                            "VALUES(nextval('sectors_id_seq'::regclass), @name, @createdDate, NULL);";

                        using (NpgsqlCommand cmd = new() { Connection = conn, CommandText = queryInsert })
                        {
                            cmd.Parameters.AddWithValue("@name", TextBoxName.Text.Trim());
                            cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);

                            cmd.ExecuteNonQuery();

                            ShowSectorsGrid();

                            ClearFields();

                            MessageBox.Show("Setor adicionado com sucesso!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

            }
        }

        private void ButtonClearClick(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
