using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KNS.Fabric
{
    public partial class MaterialListForm : Form
    {
        MySqlConnection conn = new MySqlConnection(DatabaseConnector.ConnectionString);
        MySqlDataAdapter adapter;
        DataSet dataSet;
        public MaterialListForm()
        {
            InitializeComponent();

            string query = "SELECT * FROM materials";

            conn.Open();
            adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvMaterials.DataSource = dataSet.Tables[0];
            conn.Close();

            dgvMaterials.Columns[0].HeaderText = "ID";
            dgvMaterials.Columns[0].ReadOnly = true;
            dgvMaterials.Columns[1].HeaderText = "Название";
            dgvMaterials.Columns[2].HeaderText = "Цвет";
            dgvMaterials.Columns[3].HeaderText = "Структура";
            dgvMaterials.Columns[4].HeaderText = "Ширина";
            dgvMaterials.Columns[5].HeaderText = "Длина";
            dgvMaterials.Columns[6].HeaderText = "Цена";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var row = dataSet.Tables[0].NewRow();
            dataSet.Tables[0].Rows.Add(row);
            adapter = new MySqlDataAdapter("SELECT * FROM materials", DatabaseConnector.ConnectionString);

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMaterials.SelectedRows)
            {
                dgvMaterials.Rows.Remove(row);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter.Update(dataSet);
            dataSet.Clear();
            adapter.Fill(dataSet);
            conn.Close();
        }
    }
}
