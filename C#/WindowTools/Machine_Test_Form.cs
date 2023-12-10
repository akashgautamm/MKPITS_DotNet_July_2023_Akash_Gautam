using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Test_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            StringBuilder sb = new StringBuilder();
            if (textBox1.Text == "" && numericUpDown1.Value==0)
            {
                MessageBox.Show("Please Enter Name and Age");
                
            }
            else if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter name");
            }
            else if(numericUpDown1.Value==0 )
            {
                MessageBox.Show("Please enter age");
            }
            else if(numericUpDown1.Value<=18 )
            {
                MessageBox.Show("Please enter age greater than 18");
            }
            else
            {
                sb.Append("\nStudent Name: " + textBox1.Text);
                sb.Append("\nStudent Age: " + numericUpDown1.Text + "\n");
            }
            
           
            label3.Text= sb.ToString();
            
        }
    }
}
