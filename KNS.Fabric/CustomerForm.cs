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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

            this.Text = "Экран заказчика (" + Login.login + ")";
        }

        private void btNewOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm of = new NewOrderForm();
            this.Hide();
            of.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btMyOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListForm ol = new OrderListForm();
            ol.Show();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
