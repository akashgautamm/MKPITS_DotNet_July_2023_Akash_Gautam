using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            temp = Convert.ToInt32(textBox1.Text);
            if (temp < 0)
                label2.Text = "It is Freezing weather";
            else if (temp > 0 && temp < 20)
                label2.Text = "It is Cold weather";
            else if (temp > 20 && temp < 40)
                label2.Text = "It is a Hot weather";
            else
                label2.Text = "It is a very Hot weather";


        }
    }
}
