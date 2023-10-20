using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Length_Breadth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length, breath,result;
            length = Convert.ToInt32(textBox1.Text);
            breath = Convert.ToInt32(textBox2.Text);

            result = length * breath;
            label3.Text = "Result is :" + result;
        }
    }
}
