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
            if (ValidadeFilledFields() && conn.State == ConnectionState.Closed)
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

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields() && conn.State == ConnectionState.Closed)
            {
                var confimation = MessageBox.Show($"Tem certeza que deseja atualizar o Id {TextBoxId.Text} ?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confimation == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        var queryInsert = "UPDATE public.sectors SET \"name\"=@name, updated_date=@updateDate WHERE id=@id;";

                        using (NpgsqlCommand cmd = new() { Connection = conn, CommandText = queryInsert })
                        {
                            cmd.Parameters.AddWithValue("@name", TextBoxName.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", int.Parse(TextBoxId.Text));
                            cmd.Parameters.AddWithValue("@updateDate", DateTime.Now);

                            cmd.ExecuteNonQuery();

                            ShowSectorsGrid();

                            ClearFields();

                            MessageBox.Show("Setor atualizado com sucesso!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (ValidadeFilledFields() && conn.State == ConnectionState.Closed)
            {
                var confimation = MessageBox.Show($"Tem certeza que deseja deletar o Id {TextBoxId.Text} ?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confimation == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        var queryInsert = "DELETE FROM public.sectors WHERE id=@id;";

                        using (NpgsqlCommand cmd = new() { Connection = conn, CommandText = queryInsert })
                        {
                            cmd.Parameters.AddWithValue("@id", int.Parse(TextBoxId.Text));

                            cmd.ExecuteNonQuery();

                            ShowSectorsGrid();

                            ClearFields();

                            MessageBox.Show("Setor deletado com sucesso!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
