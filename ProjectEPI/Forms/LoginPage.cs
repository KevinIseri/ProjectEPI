using Npgsql;
using System.Configuration;
using System.Data;

namespace ProjectEPI
{
    public partial class LoginPage : Form
    {
        public Point MOUSE_LOCATION;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginFormLoad(object sender, EventArgs e)
        {
            RemoveBackground();
        }

        private void RemoveBackground()
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

        private void MouseDown(object sender, MouseEventArgs e)
        {
            MOUSE_LOCATION = new Point(-e.X, -e.Y);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(MOUSE_LOCATION.X, MOUSE_LOCATION.Y);
                Location = mousePosition;
            }
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

                    MessageBox.Show("Login realizado com sucesso", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
