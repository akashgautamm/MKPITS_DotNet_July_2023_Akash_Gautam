using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserAndPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stri = "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            SqlConnection con = new SqlConnection(stri);
            try
            {
                con.Open();
                string insert = "insert into Employe values ('" + textBox1.Text + "' ,'" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(insert, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record inserted successful";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str= "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string update = "Update Employe set Password='" + textBox2.Text + "'where Username='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(update, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record update successful";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from  Employe where Username='" + textBox1.Text + "' or Password ='" + textBox2.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "select * from Employe where Username='" + textBox1.Text + "'";

                SqlCommand command = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Password"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label3.Text = "Record not found";
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
    }
}
