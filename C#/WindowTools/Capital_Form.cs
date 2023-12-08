using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            StringBuilder sb=new StringBuilder();
            if (radioButton1.Checked)
            {
                flag++;
            }
            else
            {

            }
            if(radioButton5.Checked)
            {
                flag++;
            }
            else
            {

            }
            if (radioButton9.Checked)
            {
                flag++;
            }
            else
            {

            }


            sb.Append("Total Marks is: " + flag);
            label1.Text = sb.ToString();
        }
    }
}
