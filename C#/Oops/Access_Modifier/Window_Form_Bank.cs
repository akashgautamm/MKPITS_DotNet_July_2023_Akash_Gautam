using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm_Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank b = null;
            int Accountno = Convert.ToInt32(textBox1.Text);
            int amount=Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if(tt=="Saving")
            {
                b = new Saving();
            }
            else if(tt=="Current")
            {
                b = new Current();
            }
            label4.Text=b.Deposit(Accountno, amount);
            label5.Text=b.Showbalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bank b = null;
            int Accountno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if (tt == "Saving")
            {
                b = new Saving();
            }
            else if (tt == "Current")
            {
                b = new Current();
            }
            label4.Text = b.Withdrawl(Accountno, amount);
            label5.Text = b.Showbalance();
        }
    }
}
