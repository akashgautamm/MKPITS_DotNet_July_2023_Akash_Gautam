using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_WindowForm_Employe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int,Employe> d =new Dictionary<int ,Employe> ();
        private void button1_Click(object sender, EventArgs e)
        {
           Employe e1=new Employe(Convert.ToInt32(textBox1.Text), textBox2.Text);
           Employe e2=new Employe(Convert.ToInt32(textBox3.Text), textBox4.Text);
            d.Add(e1.id,e1);
            d.Add(e2.id,e2);
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,Employe>kv in d)
            {
                sb.Append("Name: " + kv.Key + "Id: " + kv.Value.name+"\n");
            }
            label5.Text = sb.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
