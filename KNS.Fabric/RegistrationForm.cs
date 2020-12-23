using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace KNS.Fabric
{
    public partial class RegistrationForm : Form
    {
        MySqlConnection con = new MySqlConnection(DatabaseConnector.ConnectionString);
        bool a = false;
        bool b = false;
        bool c = false;
        bool d = false;
        private Color RedColor()
        {
            // Create a green color using the FromRgb static method.
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(255, 165, 165);
            return myRgbColor;
        }
        public RegistrationForm()
        {
            InitializeComponent();

            //Валидация
            txtFioReg.Validating += txtFioReg_Validating;
            txtLoginReg.Validating += txtLoginReg_Validating;
            txtPassReg.Validating += txtPassReg_Validating;
            txtPassCheckReg.Validating += txtPassCheckReg_Validating;
            //
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (a && b && c && d)
            {
                string query = "INSERT INTO users(name, login, pass, role) VALUES('"
                        + txtFioReg.Text + "', '" + txtLoginReg.Text + "', '" + txtPassReg.Text + "', 'Заказчик')";
                MySqlCommand command = new MySqlCommand(query, DatabaseConnector.CreateConnection());
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Пользователь зарегистрирован");
            }
            else
            {
                txtErrors.Text = errorProvider1.GetError(txtFioReg) + "\n" 
                    + errorProvider1.GetError(txtLoginReg) + "\n" 
                    + errorProvider1.GetError(txtPassReg) + "\n" 
                    + errorProvider1.GetError(txtPassCheckReg);
                    MessageBox.Show("Неправильно заполнены поля");
            }
        }

        private void txtFioReg_Validating(object sender, CancelEventArgs e)
        {
            a = false;
            if (String.IsNullOrEmpty(txtFioReg.Text))
            {
                errorProvider1.SetError(txtFioReg, "Не указано ФИО");
            }
            else if (txtFioReg.Text.Length > 45)
            {
                errorProvider1.SetError(txtFioReg, "Слишком длинное поле ФИО");
            }
            else
            {
                a = true;
                errorProvider1.Clear();
            }
        }

        private void txtLoginReg_Validating(object sender, CancelEventArgs e)
        {
            b = false;
            if (String.IsNullOrEmpty(txtLoginReg.Text))
            {
                errorProvider1.SetError(txtLoginReg, "Не указано Имя пользователя");
            }
            else if (txtLoginReg.Text.Length > 45)
            {
                errorProvider1.SetError(txtLoginReg, "Слишком длинное Имя пользователя");
            }
            else
            {
                b = true;
                errorProvider1.Clear();
            }
        }

        private void txtPassReg_Validating(object sender, CancelEventArgs e)
        {
            c = false;
            if (String.IsNullOrEmpty(txtPassReg.Text))
            {
                errorProvider1.SetError(txtPassReg, "Не указан пароль");
            }
            else if (txtPassReg.Text.Length < 8)
            {
                errorProvider1.SetError(txtPassReg, "Пароль должен содержать больше 8 символов");
            }
            else if (!Pass(txtPassReg.Text))
            {
                errorProvider1.SetError(txtPassReg, "Пароль должен содержать цифры и буквы в верхнем и нижем регистре");
            }
            else
            {
                c = true;
                errorProvider1.Clear();
            }
        }

        private void txtPassCheckReg_Validating(object sender, CancelEventArgs e)
        {
            d = false;
            if (String.IsNullOrEmpty(txtPassCheckReg.Text))
            {
                errorProvider1.SetError(txtPassCheckReg, "Не указан пароль");
            }
            else if (txtPassCheckReg.Text.Length < 8)
            {
                errorProvider1.SetError(txtPassCheckReg, "Пароль должен содержать больше 8 символов");
            }
            else if (!Pass(txtPassCheckReg.Text))
            {
                errorProvider1.SetError(txtPassCheckReg, "Пароль должен содержать цифры и буквы в верхнем и нижем регистре");
            }
            else if (txtPassCheckReg.Text != txtPassReg.Text)
            {
                errorProvider1.SetError(txtPassCheckReg, "Пароли не совпадают");
            }
            else
            {
                d = true;
                errorProvider1.Clear();
            }
        }
        private bool Pass(string password)
        {
            Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,45}$");
            Match match = regex.Match(password);
            return match.Success;
        }

        private void txtFioReg_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFioReg.Text))
            {
                txtFioReg.BackColor = RedColor();
            }
            else if (txtFioReg.Text.Length > 45)
            {
                txtFioReg.BackColor = RedColor();
            }
            else
            {
                txtFioReg.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void txtLoginReg_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLoginReg.Text))
            {
                txtLoginReg.BackColor = RedColor();
            }
            else if (txtLoginReg.Text.Length > 45)
            {
                txtLoginReg.BackColor = RedColor();
            }
            else
            {
                txtLoginReg.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void txtPassReg_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassReg.Text))
            {
                txtPassReg.BackColor = RedColor();
            }
            else if (txtPassReg.Text.Length < 8)
            {
                txtPassReg.BackColor = RedColor();
            }
            else if (!Pass(txtPassReg.Text))
            {
                txtPassReg.BackColor = RedColor();
            }
            else
            {
                txtPassReg.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void txtPassCheckReg_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassCheckReg.Text))
            {
                txtPassCheckReg.BackColor = RedColor();
            }
            else if (txtPassCheckReg.Text.Length < 8)
            {
                txtPassCheckReg.BackColor = RedColor();
            }
            else if (!Pass(txtPassCheckReg.Text))
            {
                txtPassCheckReg.BackColor = RedColor();
            }
            else if (txtPassCheckReg.Text != txtPassReg.Text)
            {
                txtPassCheckReg.BackColor = RedColor();
            }
            else
            {
                txtPassCheckReg.BackColor = Color.FromArgb(255, 255, 255);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
