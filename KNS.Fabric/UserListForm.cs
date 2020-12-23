using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNS.Fabric
{
    public partial class UserListForm : Form
    {
        MySqlDataAdapter adapter;
        DataSet dataSet;
        MySqlConnection con = new MySqlConnection(DatabaseConnector.ConnectionString);
        public UserListForm()
        {
            InitializeComponent();
            string query = "SELECT * FROM users";

            con.Open();
            adapter = new MySqlDataAdapter(query, con);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvUsers.DataSource = dataSet.Tables[0];
            con.Close();

            dgvUsers.Columns[0].HeaderText = "ID";
            dgvUsers.Columns[0].ReadOnly = true;
            dgvUsers.Columns[1].HeaderText = "Login";
            dgvUsers.Columns[2].HeaderText = "Password";
            dgvUsers.Columns[3].HeaderText = "Role";
            dgvUsers.Columns[4].HeaderText = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            adapter.Update(dataSet);
            dataSet.Clear();
            adapter.Fill(dataSet);
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var row = dataSet.Tables[0].NewRow();
            dataSet.Tables[0].Rows.Add(row);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.SelectedRows)
            {
                dgvUsers.Rows.Remove(row);
            }
        }

        private void UserListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

        }
    }
}
