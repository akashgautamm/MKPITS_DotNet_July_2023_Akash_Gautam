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

namespace Collection_WindowForm_Stack_Employe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack s=new Stack();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Employe e1=new Employe(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text));
            s.Push(e1);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           
            foreach(Employe str in s)
            {
                sb.Append("Id: "+str.id+"Name: "+str.name+"Salary: "+str.salary+"\n");              
            }   
            label4.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            s.Pop();
            foreach (Employe str in s)
            {
                sb1.Append("Id: " + str.id + "Name: " + str.name + "Salary: " + str.salary + "\n");
            }
           
            label4.Text = sb1.ToString();
        }
    }
}
