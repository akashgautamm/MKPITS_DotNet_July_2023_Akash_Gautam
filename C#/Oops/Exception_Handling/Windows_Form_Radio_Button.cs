using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_RadioButton_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int balance = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int account=Convert.ToInt32(textBox2.Text);
            int amount=Convert.ToInt32(textBox3.Text);
            if (radioButton1.Checked)
                balance = balance + amount;
            else if (radioButton2.Checked)
                balance = balance - amount;
            label4.Text = "Account Name: " + name+"\nAccount Number: "+account+"\nEnter Amount: "+amount+"\nBalance is: "+balance;
        }
    }
}
