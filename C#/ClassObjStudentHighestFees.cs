using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassObjStudentHighestFees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] std = new Student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            std[0] = new Student();
            std[1] = new Student();
            std[2] = new Student();
            std[3] = new Student();
            std[4] = new Student();
            std[5] = new Student();
            std[6] = new Student();
            std[7] = new Student();
            std[8] = new Student();
            std[9] = new Student();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<10)
            {
                std[cnt].id=Convert.ToInt32(textBox1.Text);
                std[cnt].name = textBox2.Text;
                std[cnt].fees= Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if(cnt==10)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;   
                    textBox3.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 10 student accepted");
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int cnt=0;cnt<10;cnt++)
            {
                sb.Append("\n-----------------------------");
                sb.Append("\nRoll No: " + std[cnt].id);
                sb.Append("\nName: " + std[1].name);
                sb.Append("\nMarks: " + std[2].fees);
                sb.Append("\n-----------------------------");
            }
            label4.Text = sb.ToString();
            int high = std[0].fees;
            int format = 0;
            for(int cnt=1;cnt<10;cnt++)
            {
                if (high < std[cnt].fees)
                {
                    high= std[cnt].fees;
                    format = cnt;
                }
            }
            StringBuilder sb1= new StringBuilder();
            sb1.Append("\nRoll No: " + std[format].id);
            sb1.Append("\nName: " + std[format].name);
            sb1.Append("\nFees: " + std[format].fees);
            label5.Text= sb1.ToString();

        }
    }
}
