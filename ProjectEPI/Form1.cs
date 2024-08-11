using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace ProjectEPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Server=localhost;Database=postgres;User id=postgres;Password=root;TrustServerCertificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //String username, userPassword;

            //username = txt_user.Text;
            //userPassword = txt_password.Text;

            //try
            //{
            //    String query = "SELECT * FROM Users WHERE UserName = '" + txt_user.Text + "' AND Password = '" + txt_password.Text + "'";
            //    SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //    DataTable dataTable = new DataTable();
            //    sda.Fill(dataTable);

            //    if (dataTable.Rows.Count > 0)
            //    {
            //        username = txt_user.Text;
            //        userPassword = txt_password.Text;

            //        // add page that needed to be load next
            //        MessageBox.Show("Login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        //Menuform form2 = new Menuform();
            //        //form2.show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txt_user.Clear();
            //        txt_password.Clear();

            //        txt_user.Focus();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{
            //    con.Close();
            //}
            //@"Host=localhost;Database=postgres;Password=***********;Persist Security Info=True;Username=postgres"
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con.Open();
            MessageBox.Show("OPEN");
            con.Close();

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
