using Npgsql;
using System.Configuration;
using System.Data;

namespace ProjectEPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, userPassword;

            username = txt_user.Text;
            userPassword = txt_password.Text;

            NpgsqlConnection conn = new (ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            try
            {
                conn.Open();

                String query = "SELECT * FROM users WHERE username = '"+txt_user.Text+"' AND password = '"+txt_password.Text+"'";

                NpgsqlCommand comn = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = query
                };

                NpgsqlDataReader dr = comn.ExecuteReader();

                if (dr.HasRows)
                {
                    username = txt_user.Text;
                    userPassword = txt_password.Text;

                    // add page that needed to be load next
                    MessageBox.Show("Login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Menuform form2 = new Menuform();
                    //form2.show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_user.Clear();
                    txt_password.Clear();

                    txt_user.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_login_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;

            res = MessageBox.Show("Deseja sair do aplicativo?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button_login_clear_Click(object sender, EventArgs e)
        {
            txt_user.Clear();
            txt_password.Clear();

            txt_user.Focus();
        }
    }
}
