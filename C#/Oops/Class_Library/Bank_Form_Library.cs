using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bankaccount;

namespace Bank_Form_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account b = null;
        private void button1_Click(object sender, EventArgs e)
        {
            
            string res= b.deposit(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            label4.Text = res;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Saving")
                b = new Saving();
            else if (comboBox1.Text == "Current")
                b = new Current();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res=b.withdrawl(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res = b.showbalance();
            label4.Text = res;
        }
    }
}
