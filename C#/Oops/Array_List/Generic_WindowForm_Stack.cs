using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_WindowForm_Stack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Stack<int> stack = new Stack<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            stack.Push(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(int s in stack)
                stringBuilder.Append(s);
            label2.Text = stringBuilder.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            stack.Pop();
            foreach(int s in stack)
                sb.Append(s);
            label2.Text= sb.ToString();
        }
    }
}
