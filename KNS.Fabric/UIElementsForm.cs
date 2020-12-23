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
    public partial class UIElementsForm : Form
    {
        public UIElementsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled=true;
            button3.Height = Convert.ToInt32(button3.Height)*2;
            button4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
                richTextBox1.Visible = false;
            if (checkBox1.Checked == false)
                richTextBox1.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                maskedTextBox1.Enabled = false;
                checkBox3.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                maskedTextBox1.Enabled = true;
                checkBox3.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Новый");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Location = new Point(17, 126);
            btn.Size = new Size(112, 32);
            btn.Name = "firstButton";
            btn.Text = "button5";
            this.Controls.Add(btn);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1.0");
        }
    }
}
