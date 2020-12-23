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
    public partial class FurnitureListForm : Form
    {
        MySqlDataAdapter adapter;
        DataSet dataSet;
        MySqlConnection conn = new MySqlConnection(DatabaseConnector.ConnectionString);
        public FurnitureListForm()
        {
            InitializeComponent();

            adapter = new MySqlDataAdapter("SELECT * FROM furnitures", DatabaseConnector.ConnectionString);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            conn.Open();
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dgvFurnitureList.DataSource = dataSet.Tables[0];
            conn.Close();

            dgvFurnitureList.Columns[0].HeaderText = "ID";
            dgvFurnitureList.Columns[0].ReadOnly = true;
            dgvFurnitureList.Columns[1].HeaderText = "Название";
            dgvFurnitureList.Columns[2].HeaderText = "Тип";
            dgvFurnitureList.Columns[3].HeaderText = "Вес";
            dgvFurnitureList.Columns[4].HeaderText = "Цена";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            adapter.Update(dataSet);
            dataSet.Clear();
            adapter.Fill(dataSet);
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var row = dataSet.Tables[0].NewRow();
            dataSet.Tables[0].Rows.Add(row);
            adapter = new MySqlDataAdapter("SELECT * FROM furnitures", DatabaseConnector.ConnectionString);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvFurnitureList.SelectedRows)
            {
                dgvFurnitureList.Rows.Remove(row);
            }
        }
    }
}
