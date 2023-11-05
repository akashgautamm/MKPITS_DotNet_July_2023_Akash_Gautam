using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Object_Form_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Book[] b = new Book[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            b[0] = new Book();
            b[1] = new Book();
            b[2] = new Book();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                b[cnt].Name = textBox1.Text;
                b[cnt].Title = textBox2.Text;
                b[cnt].Author= textBox3.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if(cnt==3)
                {

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("Already enter 3 Books Details");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int cnt=0;cnt<3;cnt++)
            {
                sb.Append("\nBook Name: " + b[cnt].Name);
                sb.Append("\nBook Name: " + b[cnt].Title);
                sb.Append("\nBook Name: " + b[cnt].Author);
                sb.Append("\n--------------------------------");

            }
            label4.Text = sb.ToString();
        }
    }
}
