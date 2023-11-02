using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObjFormEmployeHighSal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employe[] emp = new Employe[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employe();
            emp[1] = new Employe();
            emp[2] = new Employe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                emp[cnt].EmployeId = Convert.ToInt32(textBox1.Text);
                emp[cnt].EmployeName = textBox2.Text;
                emp[cnt].EmployeSalary = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();

                if (cnt==3)
                {

                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Already 3 employe aceepted");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int cnt=0;cnt<3;cnt++)
            {
                sb.Append("\n---------------------------------");
                sb.Append("\nEmploye Id =" + emp[cnt].EmployeId);
                sb.Append("\nEmploye Name =" + emp[cnt].EmployeName);
                sb.Append("\nEmploye Salary =" + emp[cnt].EmployeSalary);
                sb.Append("\n---------------------------------");

            }
            label4.Text = sb.ToString();
            int high = emp[0].EmployeSalary;
            int foundat= 0;
            for(int cnt=1;cnt<3;cnt++)
            {
                    if (high < emp[cnt].EmployeSalary) 
                    {
                        high = emp[cnt].EmployeSalary;
                        foundat = cnt;
                    }
               
            }
            StringBuilder sb1 = new StringBuilder();

            sb1.Append("Employe Id = " + emp[foundat].EmployeId);
            sb1.Append("Employe Name = " + emp[foundat].EmployeName);
            sb1.Append("Employe Salary = " + emp[foundat].EmployeSalary);
            label5.Text = sb1.ToString();
           

        }
    }
}
