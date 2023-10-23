using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char op;
            op = Convert.ToChar(textBox1.Text);
            if (op == 'E')
                label2.Text = "Excellent";
            else if (op == 'V')
                label2.Text = "Very Good";
            else if (op == 'G')
                label2.Text = "Good";
            else if (op == 'A')
                label2.Text = "Average";
            else if (op == 'F')
                label2.Text = "Fail";
            else
                label2.Text = "Invalid grade";



        }
    }
}
