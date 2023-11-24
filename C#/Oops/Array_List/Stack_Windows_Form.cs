using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Stack_Window_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack st = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            st.Push(Convert.ToChar(textBox1.Text));
            textBox1.Clear();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Char c in st)
            {
                sb.Append("\nChar: " + c);
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            st.Pop();
            foreach(Char c in st)
            {
                sb1.Append(c);   
            }    
        }
    }
}
