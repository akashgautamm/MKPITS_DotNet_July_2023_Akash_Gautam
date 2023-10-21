using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTriangleCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            int total = 0;
            n1=Convert.ToInt32(textBox1.Text);
            n2=Convert.ToInt32(textBox2.Text);
            total = n1 + n2;
            label3.Text = "Total is " + total;
        }
    }
}
