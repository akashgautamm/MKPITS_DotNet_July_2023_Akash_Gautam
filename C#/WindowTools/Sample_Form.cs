using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Mumbai");
                    break;
                case "Australia":
                    comboBox2.Items.Add("New York");
                    comboBox2.Items.Add("Washigton");
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nUsername: " + textBox1.Text);
            sb.Append("\nPassword: " + textBox2.Text);
            string gender = null;
            if (radioButton1.Checked)
                gender = radioButton1.Text;
            else if (radioButton2.Checked)
                gender = radioButton2.Text;
            sb.Append("\nGender: " + gender);
            string course = null;
            if (checkBox1.Checked)
                course = checkBox1.Text;
            if (checkBox2.Checked)
                course = course + " " + checkBox1.Text;
            sb.Append("\nCourse: " + course);
            sb.Append("\nCountry: " + comboBox1.Text);
            sb.Append("\nCity: " + comboBox2.Text);
            label7.Text=sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
