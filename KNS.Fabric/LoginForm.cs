using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KNS.Fabric
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            var reg = new RegistrationForm();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool a = true;
            MySqlConnection con = new MySqlConnection(DatabaseConnector.ConnectionString);
            con.Open();

            MySqlCommand command = new MySqlCommand("select pass from users where login = '" + txtLoginL.Text + "'", con);
            MySqlCommand command2 = new MySqlCommand("select role from users where login = '" + txtLoginL.Text + "'", con);
            string pass = (string)command.ExecuteScalar();
            string role = (string)command2.ExecuteScalar();
            con.Close();
            Login.login = txtLoginL.Text;
            Login.role = role;

            if (txtPassL.Text == pass && role == "Кладовщик")
            {
                StockmanForm sf = new StockmanForm();
                this.Hide();
                sf.Show();
            }
            else if (txtPassL.Text == pass && role == "Менеджер")
            {
                ManagerForm mf = new ManagerForm();
                this.Hide();
                mf.Show();
            }
            else if (txtPassL.Text == pass && role == "Заказчик")
            {
                CustomerForm cf = new CustomerForm();
                this.Hide();
                cf.Show();
            }
            else if (txtPassL.Text == pass && role == "Администратор")
            {
                AdministratorForm cf = new AdministratorForm();
                this.Hide();
                cf.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
                a = false;
            }
            if(a)
            {
                con.Open();
                MySqlCommand command3 = new MySqlCommand("select id from users where login = '" + txtLoginL.Text + "'", con);
                int id = (int)command3.ExecuteScalar();
                Login.id = id.ToString();
                con.Close();
            }
            a = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    public static class Login
    {
        public static string login;
        public static string role;
        public static string id;
    }
}
