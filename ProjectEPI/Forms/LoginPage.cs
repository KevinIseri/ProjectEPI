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
            LabelLoginTitle.Parent = PictureBoxBackground;
            LabelLoginTitle.BackColor = Color.Transparent;

            LabelLoginUser.Parent = PictureBoxBackground;
            LabelLoginUser.BackColor = Color.Transparent;

            LabelLoginPass.Parent = PictureBoxBackground;
            LabelLoginPass.BackColor = Color.Transparent;

            PictureBoxLogo.Parent = PictureBoxBackground;
            PictureBoxLogo.BackColor = Color.Transparent;

            PictureBoxCloseButton.Parent = PictureBoxBackground;
            PictureBoxCloseButton.BackColor = Color.Transparent;

            PictureBoxMinimizeButton.Parent = PictureBoxBackground;
            PictureBoxMinimizeButton.BackColor = Color.Transparent;
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.InnerException?.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinimizeButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButtonClick(object sender, EventArgs e)
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
    }
}
