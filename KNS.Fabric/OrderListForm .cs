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
    public partial class OrderListForm : Form
    {
        MySqlConnection connection = DatabaseConnector.CreateConnection();
        MySqlDataAdapter ordersAdapter;
        MySqlDataAdapter productsAdater;
        DataSet ordersDataSet;
        DataSet productsDataSet;
        private void LoadOrders()
        {
            connection.Open();
            string client = "";
            if(Login.role == "Заказчик")
            {
                btSave.Enabled = false;
                btAddPosition.Enabled = false;
                client = " WHERE client = " + Login.id;
                dgvOrders.ReadOnly = true;
            }
            ordersAdapter = new MySqlDataAdapter(
                "select * from orders"+client+"; " +
                "select * from users where role='Заказчик'; " +
                "SELECT * FROM users where role='Менеджер'; " +
                "select * from product", connection);
            var commandBuilder = new MySqlCommandBuilder(ordersAdapter);

            ordersDataSet = new DataSet();
            ordersAdapter.Fill(ordersDataSet);
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = ordersDataSet.Tables[0];

            customer.ValueMember = "id";
            customer.DisplayMember = "name";
            customer.DataSource = ordersDataSet.Tables[1];

            manager.ValueMember = "id";
            manager.DisplayMember = "name";
            manager.DataSource = ordersDataSet.Tables[2];

            product_id.ValueMember = "id";
            product_id.DisplayMember = "name";
            product_id.DataSource = ordersDataSet.Tables[3];

            connection.Close();

        }

        public OrderListForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void dgvOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                var item = (DataRowView)row.DataBoundItem;

                if (Convert.ToString(item["status"]) == "Обрабатывается")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (Convert.ToString(item["status"]) == "Отменен")
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count != 1)
            {
                return;
            }

            connection.Open();

            var selectedOrder = (DataRowView)dgvOrders.SelectedRows[0].DataBoundItem;

            productsAdater = new MySqlDataAdapter("select * from order_products where order_id=" + selectedOrder["id"], connection);
            var commandBuilder = new MySqlCommandBuilder(productsAdater);

            productsDataSet = new DataSet();
            productsAdater.Fill(productsDataSet);
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.DataSource = productsDataSet.Tables[0];

            connection.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            connection.Open();
            ordersAdapter.Update(ordersDataSet);
            productsAdater.Update(productsDataSet);
            connection.Close();
        }

        private void btAddPosition_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Заказ не выбран");
                return;
            }

            var selectedOrder = (DataRowView)dgvOrders.SelectedRows[0].DataBoundItem;

            var row = productsDataSet.Tables[0].NewRow();
            row["order_id"] = selectedOrder["id"];
            productsDataSet.Tables[0].Rows.Add(row);

        }

        private void btNewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewOrderForm nof = new NewOrderForm();
            nof.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(Login.role == "Заказчик")
            {
                CustomerForm form = new CustomerForm();
                form.Show();
            }
            else if (Login.role == "Администратор") {}
            else
            {
                ManagerForm form = new ManagerForm();
                form.Show();
            }
        }

        private void OrderListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (Login.role == "Заказчик")
            {
                CustomerForm form = new CustomerForm();
                form.Show();
            }
            else if (Login.role == "Администратор") { }
            else
            {
                ManagerForm form = new ManagerForm();
                form.Show();
            }
        }
    }
}
