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

namespace Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            SqlConnection con = null;
            try
            {
                con=new SqlConnection(str);
                con.Open();
                MessageBox.Show("Connection Succesful");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseCollection.Connect();
            if(con != null) 
            {
                MessageBox.Show("Successful Connected");
                con.Close();
            }
            else
            {
                MessageBox.Show("Do not connected in sql server");
            }

        }
    }
}
