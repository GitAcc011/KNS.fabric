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
    public partial class ProductListForm : Form
    {
        MySqlDataAdapter adapter;
        DataSet dataSet;
        MySqlConnection conn = new MySqlConnection(DatabaseConnector.ConnectionString);
        public ProductListForm()
        {
            InitializeComponent();

            adapter = new MySqlDataAdapter("SELECT * FROM product", DatabaseConnector.ConnectionString);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
            conn.Open();
            dataSet = new DataSet();

            adapter.Fill(dataSet);
            dgvProductList.DataSource = dataSet.Tables[0];
            conn.Close();

            dgvProductList.Columns[0].HeaderText = "ID";
            dgvProductList.Columns[0].ReadOnly = true;
            dgvProductList.Columns[1].HeaderText = "Название";
            dgvProductList.Columns[2].HeaderText = "Ширина";
            dgvProductList.Columns[3].HeaderText = "Длина";
            dgvProductList.Columns[4].HeaderText = "Изображение";
            dgvProductList.Columns[5].HeaderText = "Комментарий";
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
            adapter = new MySqlDataAdapter("SELECT * FROM product", DatabaseConnector.ConnectionString);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProductList.SelectedRows)
            {
                dgvProductList.Rows.Remove(row);
            }
        }
    }
}
