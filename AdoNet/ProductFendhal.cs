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

namespace ProductFendhal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true;database=ProductFendhal";
        SqlConnection con = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        public enum Nationality { INDIA,NRI}
        Nationality nat;

        private void Form1_Load(object sender, EventArgs e)
        {
            Category();
            Product();
            price();
            nat = Nationality.INDIA;
        }
        public void Category()
        {
            try
            {


                con = new SqlConnection(str);
                da = new SqlDataAdapter("Select * from TableProductCategory", con);
                ds = new DataSet();
                da.Fill(ds, "Tablecategory");
                comboBox1.DataSource = ds.Tables["Tablecategory"];
                comboBox1.DisplayMember = "Product_Type_Name";
                comboBox1.ValueMember = "Product_Category_Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Product()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(str);
                    da = new SqlDataAdapter("select * from TableProduct where Product_Category_Id=@Pid", con);
                    da.SelectCommand.Parameters.AddWithValue("@Pid", comboBox1.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "TableProduct");
                    comboBox2.DataSource = ds.Tables["TableProduct"];
                    comboBox2.DisplayMember = "Product_Name";
                    comboBox2.ValueMember = "Product_Id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        public void price()
        {
            if(comboBox2.SelectedValue.ToString()!="System.Data.DataRowView")
            {
                con = new SqlConnection(str);
                da = new SqlDataAdapter("Select * from TableProduct where Product_Id=@pid", con);
                da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "TableProduct");
                foreach(DataRow dr in ds.Tables["TableProduct"].Rows)
                {
                    textBox3.Text = dr["Product_Price"].ToString();
                }
            }
        }
       

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = "0";
            textBox5.Text = "0";
            price();   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox8.Text = "0";
            Product();
            if (comboBox1.Text != "System.Row.DataRowView")
            {
                string catname = comboBox1.Text;
                con=new SqlConnection(str);
                da = new SqlDataAdapter("Select * from ProductGstDetail where Gst_Detail_Name=@gst", con);
                da.SelectCommand.Parameters.AddWithValue("@gst", catname);
                ds = new DataSet();
                da.Fill(ds, "tgst");
                foreach(DataRow dr in ds.Tables["tgst"].Rows)
                {
                    textBox7.Text = dr["CGST"].ToString();
                    textBox8.Text = dr["SGST"].ToString();
                    textBox9.Text = dr["IGST"].ToString();


                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked) 
            {
                nat = Nationality.INDIA;
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked) 
            {
                nat = Nationality.NRI;
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
            }
        }
        double tcgst = 0;
        double tsgst = 0;
        double tigst = 0;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                double price = Convert.ToDouble(textBox3.Text);
                double quantity = Convert.ToDouble(textBox4.Text);
                double totalamount = price * quantity;
                textBox5.Text = totalamount.ToString();
                double pcgst=Convert.ToDouble(textBox7.Text);
                tcgst = totalamount * (pcgst / 100);
                textBox10.Text=tcgst.ToString();
                double psgst=Convert.ToDouble(textBox8.Text);
                tsgst = totalamount * (psgst / 100);
                textBox11.Text=tsgst.ToString();
                double pigst=Convert.ToDouble(textBox9.Text);
                tigst = totalamount * (pigst / 100);
                textBox12.Text=tigst.ToString();
                if(nat.ToString()=="INDIA")
                {
                    double natamt=Convert.ToDouble(textBox10.Text)+Convert.ToDouble(textBox11.Text)+Convert.ToDouble(textBox5.Text);
                    textBox6.Text = natamt.ToString();
                }
                else if(nat.ToString()=="NRI")
                {
                    double natamount = Convert.ToInt32(textBox12.Text) +Convert.ToInt32( textBox5.Text);
                    textBox6.Text=natamount.ToString();
                }

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("Please enter detail");

            }
            else
            {
                con = new SqlConnection(str);
                con.Open();
                string str1 = "Insert into TableInvoiceDetails values(@Customer_Name,@Customer_Contact,@Product_Category_Id,@Product_Id,@Residential_Type_Id,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_Value,@IGST_Value,@Total_Amount)";
                SqlCommand cmd=new SqlCommand(str1, con);
                cmd.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Customer_Contact", textBox2.Text);
                cmd.Parameters.AddWithValue("@Product_Category_Id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@Product_Id", comboBox2.SelectedValue);
                cmd.Parameters.Add("Residential_Type_Id", SqlDbType.Int).Value = 1001;
                cmd.Parameters.AddWithValue("@Invoice_Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                cmd.Parameters.AddWithValue("@CGST", textBox7.Text);
                cmd.Parameters.AddWithValue("@SGST", textBox8.Text);
                cmd.Parameters.AddWithValue("@IGST", textBox9.Text);
                cmd.Parameters.AddWithValue("@CGST_Value", textBox10.Text);
                cmd.Parameters.AddWithValue("SGST_Value", textBox11.Text);
                cmd.Parameters.AddWithValue("IGST_Value", textBox12.Text);
                cmd.Parameters.AddWithValue("Total_Amount", textBox6.Text);
                cmd.ExecuteNonQuery();
                con.Close();



            }
        }
    }
}
