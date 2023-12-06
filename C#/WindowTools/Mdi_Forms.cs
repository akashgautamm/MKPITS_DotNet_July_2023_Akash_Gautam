using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrationform r = new Registrationform();
            r.MdiParent = this;
            r.Show();
        }

        private void admissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admissionform a = new Admissionform();
            a.MdiParent = this;
            a.Show();
        }
    }
}
