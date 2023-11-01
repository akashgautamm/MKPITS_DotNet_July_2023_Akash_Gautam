using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObjFormRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            
            r.Length=Convert.ToInt32(textBox1.Text);
           
            r.Breadth = Convert.ToInt32(textBox2.Text);

            r.Total = r.Length * r.Breadth;
            StringBuilder sb = new StringBuilder();
            sb.Append("Rectangle is :" + r.Total);
            label3.Text = sb.ToString();

        }

    }
}
