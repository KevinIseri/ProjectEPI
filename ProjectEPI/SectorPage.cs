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

            dataGridViewSectors.DataSource = sectors;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
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
                            cmd.Parameters.AddWithValue("@name", textBoxName.Text.Trim());
                            cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);

                            cmd.ExecuteNonQuery();

                            ShowSectorsGrid();

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
    }
}
