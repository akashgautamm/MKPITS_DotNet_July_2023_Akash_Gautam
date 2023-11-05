using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObjectFormStudentAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student []std = new Student[3];
        int cnt = 0;
        int[] total = new int[3];
        float[] average=new float[3];
       
        private void Form1_Load(object sender, EventArgs e)
        {
            std[0] = new Student();
            std[1] = new Student();
            std[2] = new Student();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                std[cnt].RollNo= Convert.ToInt32(textBox1.Text);
                std[cnt].Name=textBox2.Text;
                std[cnt].Marks1 = Convert.ToInt32(textBox3.Text);
                std[cnt].Marks2 =Convert.ToInt32(textBox4.Text);
                std[cnt].Marks3 = Convert.ToInt32(textBox5.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Focus();

                if(cnt==3)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("Already enter 3 subject marks");
                }
               
            }
            for(int cnt=0;cnt<3;cnt++)
            {
                total[cnt] = std[cnt].Marks1 + std[cnt].Marks2 + std[cnt].Marks3;
                average[cnt] = total[cnt] / 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int cnt=0;cnt<3;cnt++)
            {

                sb.Append("\nStudent Roll No: " + std[cnt].RollNo);
                sb.Append("\nStudent Name: " + std[cnt].Name);
                sb.Append("\nMark 1: " + std[cnt].Marks1);
                sb.Append("\nMark 2: " + std[cnt].Marks2);
                sb.Append("\nMark 3: " + std[cnt].Marks3);
                sb.Append("\nTotal marks: " + total[cnt]);
                sb.Append("\nAverage is: " + average[cnt]);
                sb.Append("\n------------------------------------");
            }
            label5.Text = sb.ToString();

            
        }
    }
}
