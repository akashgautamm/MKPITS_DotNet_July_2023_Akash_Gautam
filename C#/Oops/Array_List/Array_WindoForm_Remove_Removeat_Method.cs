using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_WindowForm_Remove_RemoveAt_Method
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
            StringBuilder sb = new StringBuilder();
            foreach(Object o in a)
            {
                sb.Append("Name: "+o.ToString()+"\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.Insert(1,textBox1.Text); 
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.Remove(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a.RemoveAt(Convert.ToInt32(textBox2.Text));
        }
    }
}
