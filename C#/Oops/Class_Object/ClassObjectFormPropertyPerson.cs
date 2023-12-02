using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObjFormPropertyPerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = textBox1.Text;
            p.Age = Convert.ToInt32(textBox2.Text);
            p.Adress = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Person Name :" + p.Name+"\n");
            sb.Append("Person Age :" + p.Age + "\n");
            sb.Append("Person Adress :" + p.Adress + "\n");
            label4.Text = sb.ToString();
        }
    }
}
