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

namespace Array_WindowForm_Employe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employe er;
        ArrayList a = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            er = new Employe (Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
            a.Add(er);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employe o in a)
            {
                sb.Append("\nId: " + o.id);
                sb.Append("\nName: " + o.name);
                sb.Append("\nsalary: " + o.salary);
                sb.Append("\nDesignation: " + o.designation);
            }
            label5.Text = sb.ToString();
        }
    }
}
