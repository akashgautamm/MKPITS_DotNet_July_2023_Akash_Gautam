using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculatee;

namespace Calculate_Form_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate c = new Calculate();
        private void button2_Click(object sender, EventArgs e)
        {
            int r=c.Substract(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            label3.Text = "Substract is: " + r;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int r=c.Additon(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Addition is: " + r;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = c.Multiply(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Multiply is: " + r;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = c.Divide(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Divide is: " + r;
        }
    }
}
