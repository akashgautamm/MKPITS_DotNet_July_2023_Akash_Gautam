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

namespace Array_WindowForm_Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product pr;
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            pr=new Product(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3));
            ar.Add(pr);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           StringBuilder sb=new StringBuilder();
            foreach(Product p in ar) {
                sb.Append("Id: " + p.id);
                sb.Append("Name: " + p.name);
                sb.Append("Rate: " + p.rate);
            }
            label4.Text= sb.ToString();
        }
    }
}
