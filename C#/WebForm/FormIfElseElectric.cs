using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseElectric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            float total = 0, schar = 0, unit,bill=0;
            string name;
            name = Convert.ToString(textBox1.Text);
            id=Convert.ToInt32(textBox2.Text);
            unit=Convert.ToSingle(textBox3.Text);

            if(unit<=100)
            {
                total = unit * 1;
            }
            else if(unit>100 && unit<=400)
            {
                total = unit * 2;
            }
            else if (unit > 400 && unit <= 600)
            {
                total = unit * 3;
            }
            else if (unit > 600)
            {
                total = unit * 4;
            }
            if (total>=400)
            {
                schar = total * 0.15f;
            }
            bill = total + schar;

            label4.Text = "Customer Name :" + name;
            label5.Text = "Customer Id :" + id;
            label6.Text = "Unit consume :" + unit;
            label7.Text = "Amount charges :" + total;
            label8.Text = "Scharge amount :" + schar;
            label9.Text = "Total Bill :" + bill;


        }
    }
}
