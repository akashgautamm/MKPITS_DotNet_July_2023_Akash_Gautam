using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char op;
            op=Convert.ToChar(textBox1.Text);
            if(op=='a' ||  op=='e' || op=='i' || op=='o' || op=='u'  )
            {
                label2.Text = "It is a Vowel";
            
            }
            else
            {
                label2.Text = "It is a Consonent";
            }
        }
    }
}
