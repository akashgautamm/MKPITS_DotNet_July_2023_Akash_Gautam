using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi_ContextMenue_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Accountform a = new Accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrationform a = new Registrationform();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
