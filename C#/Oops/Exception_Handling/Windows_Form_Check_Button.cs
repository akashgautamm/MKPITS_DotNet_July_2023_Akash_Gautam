using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Bonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float bonus = 0.0f;
            float totalsalary = 0.0f;
            string name = textBox1.Text;
            int basic=Convert.ToInt32(textBox2.Text);
            string desig=comboBox1.Text;
            switch(desig)
            {
                case "Manager":
                    bonus = basic * 0.45f;
                    break;
                case "Clerk":
                    bonus = basic * 0.25f;
                    break;
                case "Peon":
                    bonus = basic * 0.10f;
                    break;

            }
            totalsalary = basic + bonus;
            label4.Text = "Name: " + name + "\nBasic Salary: " + basic;
            if(checkBox1.Checked)
            {
                label4.Text = "\nBonus is: " + bonus;
            }
            
            
            
            if(checkBox2.Checked)
            {
                label5.Text = "\nTotal salary: " + totalsalary;
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
