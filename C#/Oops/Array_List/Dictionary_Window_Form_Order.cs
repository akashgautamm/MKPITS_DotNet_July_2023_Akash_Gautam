using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_WindowForm_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Dictionary<int, Order> d = new Dictionary<int, Order>();
        Order order=null;
        private void button1_Click(object sender, EventArgs e)
        {
            order = new Order(Convert.ToInt32(textBox1.Text), textBox2.Text,Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            d.Add(order.id, order);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           StringBuilder sb = new StringBuilder();
            int t= 0;
            foreach (KeyValuePair<int, Order> kvp in d)
            {
                int total = order.quantity * order.rate;
                t = t + total;
                sb.Append("\nProduct Id: " + kvp.Key + "\nProduct Name: " + kvp.Value.name + "\nProduct Rate: " + kvp.Value.rate + "\nProduct Quantity: " + kvp.Value.quantity+"\nTotal is: "+total);
                sb.Append("\n-------------------------------------------------------------");
            }
            label5.Text = sb.ToString();
            MessageBox.Show("Total amount: " + t);
        }
    }
}
