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
    public partial class NewOrderForm : Form
    {
        MySqlConnection connection = DatabaseConnector.CreateConnection();
        public NewOrderForm()
        {
            InitializeComponent();
            string id = "";
            if (Login.role == "Заказчик")
            {
                label2.Visible = false;
                label3.Visible = false;
                cbCustomer.Visible = false;
                cbManager.Visible = false;
                id = " and id = " + Login.id;
            }
            connection.Open();

            // создаем DataSet для чтения данных и заполнения элементов управления ComboBox
            var dataSet = new DataSet();
            // адаптер будет считывать из БД в DataSet сразу три таблицы 
            var adapter = new MySqlDataAdapter(
                "select * from users where Role='Заказчик'" + id + "; " +
                "select * from users where Role='Менеджер'; " +
                "select * from product", connection);

            adapter.Fill(dataSet);

            // связываем cbCustomer с 0-й таблицей внутри dataSet
            // свойства ValueMember и DisplayMember изучите самостоятельно
            cbCustomer.ValueMember = "id";
            cbCustomer.DisplayMember = "name";
            cbCustomer.DataSource = dataSet.Tables[0];

            // связываем cbManager с 1-й таблицей внутри dataSet
            cbManager.ValueMember = "id";
            cbManager.DisplayMember = "name";
            cbManager.DataSource = dataSet.Tables[1];

            // связываем cbProduct с 2-й таблицей внутри dataSet
            cbProduct.ValueMember = "id";
            cbProduct.DisplayMember = "name";
            cbProduct.DataSource = dataSet.Tables[2];

            connection.Close();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            connection.Open();

            // настраиваем DataSet для работы с таблицей orders в памяти
            var dataSet = new DataSet();
            var adapter = new MySqlDataAdapter("select * from orders", connection);
            var commandBuilder = new MySqlCommandBuilder(adapter);
            adapter.Fill(dataSet);

            // создаем в памяти новую строку DataRow
            DataRow dr = dataSet.Tables[0].NewRow();
            // заполняем все колонки нового заказа
            dr["date"] = dtpDate.Value;
            dr["status"] = "Новый";
            dr["client"] = cbCustomer.SelectedValue;
            if (Login.role == "Заказчик") {}
            else
                dr["manager"] = cbManager.SelectedValue;
            // добавляем новую строку в таблицу orders
            dataSet.Tables[0].Rows.Add(dr);
            // сохраняем изменения в базе данных
            adapter.Update(dataSet);
            dataSet.Clear();
            adapter.Fill(dataSet);

            // считываем id заказа, который был сохранен в базе данных, чтобы использовать его для вставки записей в таблицу order_products
            int orderId = (int)dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1]["id"];

            // настраиваем DataSet для работы с таблицей order_products в памяти
            var dataSet2 = new DataSet();
            var adapter2 = new MySqlDataAdapter("select * from order_products", connection);
            var commandBuilder2 = new MySqlCommandBuilder(adapter2);
            adapter2.Fill(dataSet2);

            // проходим в цикле по всем строкам грида (по позициям заказа)
            foreach (DataGridViewRow row in dgvOrderProducts.Rows)
            {
                // пропускаем строку, если в ней не выбрано изделие
                if (row.Cells[0].Value == null)
                {
                    continue;
                }

                // создаем в памяти новую строку DataRow
                DataRow dr2 = dataSet2.Tables[0].NewRow();
                // заполняем все колонки новой позиции заказа
                dr2["order_id"] = orderId;
                dr2["product_id"] = row.Cells[0].Value;
                dr2["quantity"] = row.Cells[1].Value;
                // добавляем новую строку в таблицу order_products
                dataSet2.Tables[0].Rows.Add(dr2);
                // сохраняем изменения в базе данных
                adapter2.Update(dataSet2);
            }

            connection.Close();

            // закрываем форму
            Close();

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            if (Login.role == "Менеджер")
            {
                ManagerForm form = new ManagerForm();
                form.Show();
            }
            else if (Login.role == "Заказчик")
            {
                CustomerForm form = new CustomerForm();
                form.Show();
            }
        }

        private void NewOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (Login.role == "Менеджер")
            {
                ManagerForm form = new ManagerForm();
                form.Show();
            }
            else if (Login.role == "Заказчик")
            {
                CustomerForm form = new CustomerForm();
                form.Show();
            }
        }
    }
}
