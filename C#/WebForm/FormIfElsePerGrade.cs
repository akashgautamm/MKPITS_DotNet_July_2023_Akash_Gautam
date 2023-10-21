using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElsePerGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int p, m, c,total,rno;
            float per=0 ;
            string grade;

            name = Convert.ToString(textBox1.Text);
            rno = Convert.ToInt32(textBox2.Text);
            p = Convert.ToInt32(textBox3.Text);
            c=Convert.ToInt32(textBox4.Text);
            m = Convert.ToInt32(textBox5.Text);

            total = p + c + m;

            per = (total / 300.0f) * 100.0f;

            if (per >= 75)
            {
                grade = "First";

            }
            else if (per >= 60 && per < 75)
            {
                grade = "Second";
            }
            else if (per >=35 && per < 60)
            {
                grade = "Third";
            }
            else
            {
                grade = "Fail";

            }
            label6.Text = "Name is "+name;
            label7.Text = "Percent is "+per;
            label8.Text = "Grade is "+grade;



        }
    }
}
