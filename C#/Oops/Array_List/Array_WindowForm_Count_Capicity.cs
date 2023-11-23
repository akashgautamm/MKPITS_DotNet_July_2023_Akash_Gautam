using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Array_WindowForm_Count_Capicity_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList a = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            a.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity" + a.Capacity);
            MessageBox.Show("Count" + a.Count);
            StringBuilder sb = new StringBuilder();
            foreach(object o in a)
            {
                sb.Append("Name: " + o.ToString()+"\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
