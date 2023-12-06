using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi_ToolStrip_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            reges();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            acc();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reges();
        }
        public void reges()
        {
            Registrationform r = new Registrationform();
            r.MdiParent = this;
            r.Show();
        }
        public void acc()
        {
            Accountform a = new Accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acc();
        }
    }
}
