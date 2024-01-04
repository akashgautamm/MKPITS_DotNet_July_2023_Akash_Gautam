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

namespace Disconnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=Sample1");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;
        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Details", connection);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "Details");
            dataGridView1.DataSource = ds.Tables["Details"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["Details"]);
                MessageBox.Show("Record Updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }
    }
}
