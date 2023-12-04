using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Single_Digit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int prnum = 0;
        char op;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            prnum=Convert.ToInt32(textBox1.Text);
            op = 'x';
            textBox1.Text = "x";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            prnum= Convert.ToInt32(textBox1.Text);
            op = '+';
            textBox1.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            prnum = Convert.ToInt32(textBox1.Text);
            op = '-';
            textBox1.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            prnum = Convert.ToInt32(textBox1.Text);
            op = '/';
            textBox1.Text = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int result = 0;
            switch(op)
            {
                case '+':
                    result = prnum + Convert.ToInt32(textBox1.Text);
                    break;
                case '-':
                    result = prnum - Convert.ToInt32(textBox1.Text);
                    break;
                case 'x':
                    result = prnum * Convert.ToInt32(textBox1.Text);
                    break;
                case '/':
                    result = prnum / Convert.ToInt32(textBox1.Text);
                    break;
            }
            textBox1.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
