using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseMonthsNum
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

            if(num==1 || num==3 ||num == 5 || num ==7 || num ==8 || num ==10 || num ==12)
            {
                label2.Text = "It is a 31 days";
            }
            else if (num == 4 || num == 6 || num == 9 || num == 11 )
            {
                label2.Text = "It is a 30 days";
            }
            else if(num==2)
            {
                label2.Text = "It is a 28 or 29 days";
            }
            else
            {
                label2.Text = "It have a invalid month num";
            }
        }
    }
}
