using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_WindowFrom_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s;
        ArrayList a = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            s = new Student(Convert.ToInt32(textBox1.Text),textBox2.Text);
            a.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Student s in a)
            {
                sb.Append("\nRoll Number: " + s.rno);
                sb.Append("\nName: " + s.name);
            }
            label3.Text = sb.ToString();
        }
    }
}
