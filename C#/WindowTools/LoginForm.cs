using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="admin") 
            {
                registrationToolStripMenuItem1.Enabled = true;
                accountToolStripMenuItem1.Enabled=true;
                MessageBox.Show("Login Successful");
                panel1.Visible = false;
            }
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.MdiParent = this;
            r.Show();

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.MdiParent = this;
            a.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
