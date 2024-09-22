using Npgsql;
using System.Configuration;
using System.Data;

namespace ProjectEPI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            string username, userPassword;

            NpgsqlConnection conn = new(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            try
            {
                conn.Open();

                string query = $"SELECT * FROM users WHERE username = '{txtUser.Text}' AND password = '{txtPassword.Text}'";

                NpgsqlCommand cmd = new()
                {
                    Connection = conn,
                    CommandType = CommandType.Text,
                    CommandText = query
                };

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    username = txtUser.Text;
                    userPassword = txtPassword.Text;

                    MessageBox.Show("Login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainPage mainPage = new();
                    mainPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    txtPassword.Clear();

                    txtUser.Focus();
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

        private void ButtonLoginExitClick(object sender, EventArgs e)
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

        private void ButtonLoginClearClick(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();

            txtUser.Focus();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
