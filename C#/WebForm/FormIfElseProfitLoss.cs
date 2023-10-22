using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfElseProfitLoss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cp, sp, total;
            cp=Convert.ToInt32(textBox1.Text);
            sp=Convert.ToInt32(textBox2.Text);
            if(cp>sp)
            {
                total = cp - sp;
                label3.Text = "Loss is " + total;
            }
            if (sp > cp)
            {
                total = sp - cp;
                label3.Text = "Profit is " + total;
            }

        }
    }
}
