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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
            this.Text = "Экран администратора (" + Login.login + ")";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btUserList_Click(object sender, EventArgs e)
        {
            UserListForm ulf = new UserListForm();
            ulf.Show();
        }

        private void btOrderList_Click(object sender, EventArgs e)
        {
            OrderListForm olf = new OrderListForm();
            olf.Show();
        }

        private void btMaterialList_Click(object sender, EventArgs e)
        {
            MaterialListForm mlf = new MaterialListForm();
            mlf.Show();
        }

        private void btFurnitureList_Click(object sender, EventArgs e)
        {
            FurnitureListForm flf = new FurnitureListForm();
            flf.Show();
        }

        private void btProductList_Click(object sender, EventArgs e)
        {
            ProductListForm plf = new ProductListForm();
            plf.Show();
        }

        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
