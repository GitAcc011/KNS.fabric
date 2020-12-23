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
    public partial class StockmanForm : Form
    {
        public StockmanForm()
        {
            InitializeComponent();
            this.Text = "Экран кладовщика ("+Login.login+")";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void btMaterialList_Click(object sender, EventArgs e)
        {
            MaterialListForm ml = new MaterialListForm();
            ml.Show();
        }

        private void btFurnitureList_Click(object sender, EventArgs e)
        {
            FurnitureListForm fl = new FurnitureListForm();
            fl.Show();
        }

        private void btProductList_Click(object sender, EventArgs e)
        {
            ProductListForm pl = new ProductListForm();
            pl.Show();
        }

        private void StockmanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
