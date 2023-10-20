using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIfelseHeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height;
            height = Convert.ToInt32(textBox1.Text);

            if (height >= 175)
                label2.Text = "It is a Abnormal";
            else if (height > 135 && height<175)
                label2.Text = "It is a Medium";
            else
                label2.Text = "It is a Small";
        }
    }
}
