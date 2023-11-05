using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Object_Form_Bank_WithDep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int deposite = 0;
        int withdrawl = 0;
        int amount = 1000;

        private void button1_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank();
            bank.Name=textBox1.Text;
            bank.Number=Convert.ToInt32(textBox2.Text);
            bank.Balance=Convert.ToInt32(textBox3.Text);
            deposite = amount + bank.Balance;
            withdrawl=amount-bank.Balance;
            StringBuilder sb= new StringBuilder();
            sb.Append("\nBank Name: " + bank.Name);
            sb.Append("\nBank Number: "+bank.Number);
            sb.Append("\nBank Balance: " + bank.Balance);
            sb.Append("\nDeposite Amount is: " + deposite);
            label4.Text = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("\nBank Name: " + bank.Name);
            sb1.Append("\nBank Number: " + bank.Number);
            sb1.Append("\nBank Balance: " + bank.Balance);
            sb1.Append("\nWithdrawl Amount is: " + withdrawl);
            label5.Text = sb1.ToString();



        }
    }
}
