using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s=new Student();
        private void button1_Click(object sender, EventArgs e)
        {
            s.data(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
            label4.Text = s.sum();
            label5.Text = s.per();
            label6.Text=s.GRADE();
        }
    }
}
