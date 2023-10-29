using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormArrayFind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[]num =new int[5];
        int cnt;
        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<5)
            {
                num[cnt] = Convert.ToInt32(textBox1.Text);
                cnt++;
                textBox1.Clear();
                textBox1.Focus();
                if(cnt==5)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("You have entered 5 number");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            int user=Convert.ToInt32(textBox2.Text);
            for(int cnt=0;cnt<num.Length;cnt++)
            {
                if (num[cnt]==user)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
            {
                label3.Text = "Num found in array";
            }
            else
            {
                label3.Text = "Num not found in array";
            }
        }
    }
}
