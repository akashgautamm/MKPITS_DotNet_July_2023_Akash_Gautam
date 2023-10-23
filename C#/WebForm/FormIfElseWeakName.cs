using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseWeakName
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
            num=Convert.ToInt32(textBox1.Text);
            if (num == 1)
                label2.Text = "Monday";
            else if (num == 2)
                label2.Text = "Tuesday";
            else if (num == 3)
                label2.Text = "Wednesday";
            else if (num == 4)
                label2.Text = "Thursday";
            else if (num == 5)
                label2.Text = "Friday";
            else if (num == 6)
                label2.Text = "Saturday";
            else if (num == 7)
                label2.Text = "Sunday";
            else 
                label2.Text = "Invalid day No";

        }
    }
}
