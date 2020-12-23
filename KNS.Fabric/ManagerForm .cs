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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();

            this.Text = "Экран менеджера (" + Login.login + ")";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btNewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewOrderForm orderForm = new NewOrderForm();
            orderForm.Show();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btOrderManage_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderListForm orderListForm = new OrderListForm();
            orderListForm.Show();
        }
    }
}
