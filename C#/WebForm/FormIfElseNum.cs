using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox1.Text);

            if (num == 1)
                label2.Text = "One";
            else if (num == 2)
                label2.Text = "Two";
            else if (num == 3)
                label2.Text = "Three";
            else if (num == 4)
                label2.Text = "Four";
            else if (num == 5)
                label2.Text = "Five";
            else if (num == 6)
                label2.Text = "Six";
            else if (num == 7)
                label2.Text = "Seven";
            else
                label2.Text = "Invalid day No";
        }
    }
}
