using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ditionary_Window_Form_Linked_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> d = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            d.Add(textBox1.Text, textBox2.Text);
            display();

        }
        public void display()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> li = new List<string>(d.Keys);
            foreach (string s in li)
                sb.Append("\nKeys: " + s);
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> li = new List<string>(d.Values);
            foreach (string s in li)
                sb.Append("\nValues: " + s);
            label3.Text= sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           foreach(KeyValuePair<string,string>k in d)
            {
                sb.Append("Keys: " + k.Key + "Value: " + k.Value + "\n");

            }
            label3.Text = sb.ToString();
        }
    }
}
