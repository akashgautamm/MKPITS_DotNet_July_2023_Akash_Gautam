using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObjFormCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle c=new Circle();
            c.Radius1 = Convert.ToSingle(textBox1.Text);
            c.Radius2 = Convert.ToSingle(textBox2.Text);

            c.Area = 3.14f * c.Radius1 * c.Radius1;
            c.Circumference = 2 * 3.14f * c.Radius2;

            StringBuilder sb=new StringBuilder();
            sb.Append("Area of Circle :" + c.Area);
            sb.Append("\nCircumference of Circle :"+c.Circumference);
            richTextBox1.Text = sb.ToString();
        }
    }
}
