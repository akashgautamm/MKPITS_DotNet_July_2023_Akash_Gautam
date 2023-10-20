using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormIfelseQuadrant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x,y;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
          

            if (x > 0 && y > 0)
                label3.Text = "First Quadrant";
            else if (x < 0 && y > 0)
                label3.Text = "Second Quadrant";
            else if(x < 0 && y < 0)
                label3.Text = "Third Quadrant";
            else if (x > 0 && y < 0)
                label3.Text = "Forth Quadrant";
        }
    }
}
