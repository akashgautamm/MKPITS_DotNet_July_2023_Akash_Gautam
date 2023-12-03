using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generic_WindowForm_Attendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Dictionary<string, Student> d = new Dictionary<string, Student>();
        Student s = null;
        private void button1_Click(object sender, EventArgs e)
        {
            s=new Student(textBox1.Text,Convert.ToInt32(textBox2.Text),textBox3.Text);
            d.Add(s.name, s);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<string,Student> kvp in d)
            {
               
                sb.Append("Name: " + kvp.Key);
                sb.Append("\nId: " + kvp.Value.id);
                sb.Append("\nAttendance: " + kvp.Value.attend);
                sb.Append("\n---------------------------------");
            }   
            label4.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int flagp = 0;
            int flaga = 0;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, Student> kvp in d)
            {
                if (kvp.Value.attend== "p")
                {
                    flagp++;
                }
                else if (kvp.Value.attend == "a")
                {
                    flaga++;
                }
               

            }
            sb.Append("\nPresent: " + flagp);
            sb.Append("\nAbsent: " + flaga);


            label5.Text = sb.ToString();
        }
    }
}
