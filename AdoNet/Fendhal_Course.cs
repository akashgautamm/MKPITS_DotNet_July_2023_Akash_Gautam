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

namespace Fendal_Course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;Integrated security=true;database=CourseRegistration";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        float fp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Getnation();
            Getstate();
            Getcity();
            if(radioButton1.Checked)
            {
                textBox2.Text = "1000";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getstate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getcity();
        }
        public void Getnation()
        {

            try
            {

                con = new SqlConnection(str);
                da = new SqlDataAdapter("Select * from TableNation order by Nation_Id", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "Nation_Name";
                comboBox1.ValueMember = "Nation_Id";

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Getstate()
        {

            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(str);
                    da = new SqlDataAdapter("select * from TableState where Nation_Id=@Nation_Id", con);
                    da.SelectCommand.Parameters.AddWithValue("@Nation_Id", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableState");
                    comboBox2.DataSource = ds.Tables["TableState"];
                    comboBox2.DisplayMember = "State_Name";
                    comboBox2.ValueMember = "State_Id";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
        public void Getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {

                    con = new SqlConnection(str);
                    da = new SqlDataAdapter("select * from TableCity where State_Id=@State_Id", con);
                    da.SelectCommand.Parameters.AddWithValue("@State_Id", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableCity");
                    comboBox3.DataSource = ds.Tables["TableCity"];
                    comboBox3.DisplayMember = "City_Name";
                    comboBox3.ValueMember = "City_Id";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }
         public enum Category { Student,It_Professional}
         public enum Gender { Male,Female,Other}

        Category cat;
        Gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            if(selectedDate.Date<DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date.\"");
            }
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please insert your name");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat = Category.Student;
                }
                else if(radioButton2.Checked)
                {
                    cat = Category.It_Professional;
                }
                MessageBox.Show("Category " + cat);
                 if(radioButton3.Checked)
                {
                    gen = Gender.Male;
                }
                else if(radioButton4.Checked)
                {
                    gen = Gender.Female;
                }
                else if(radioButton5.Checked)
                {
                    gen = Gender.Other;
                }
                MessageBox.Show("Gender Selected " + gen);
                savecourseregdetail(cat, gen);
            }
        }
        //------------------TableCourseRegDetail----------------------//
        public void savecourseregdetail(Category c,Gender g)
        {
            try
            {
                string str = "insert into TableCourseRegDetail values(@CategoryId,@FullName,@GenderId)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@CategoryId", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", textBox1.Text);
                command.Parameters.AddWithValue("@GenderId", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                insertregaddress();
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        //------------------------TableRegAddress-----------------------//
        public void insertregaddress()
        {
            con.Open();
            string str = "select max(CourseRegId)from TableCourseRegDetail";
            SqlCommand cmd1 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd1.ExecuteScalar());
            string str1 = "Insert into TableRegAddress values(@CourseRegId,@Nation_Id,@State_Id,@City_Id)";
            SqlCommand cmd2 = new SqlCommand(str1, con);
            cmd2.Parameters.Add("@CourseRegId", SqlDbType.Int).Value = mcid;
            cmd2.Parameters.Add("@Nation_Id", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd2.Parameters.Add("@State_Id",SqlDbType.Int).Value=comboBox2.SelectedValue;
            cmd2.Parameters.Add("@City_Id", SqlDbType.Int).Value = comboBox3.SelectedValue;
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Stored in TableRegAddress");
            con.Close();
            insertfeedetai();

        }
        public void insertfeedetai()
        {
            con.Open();
            string str = "select max(CourseRegId) from TableCourseRegDetail";
            SqlCommand cmd = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd.ExecuteScalar());
            string str1 = "Insert into TableFeeDetail values(@CourseRegId,@TotalAmount,@MiniPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd1=new SqlCommand(str1, con);
            cmd1.Parameters.Add("@CourseRegId", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = textBox2.Text;
            cmd1.Parameters.Add("@MiniPer", SqlDbType.Decimal).Value = fp;
            cmd1.Parameters.Add("@PaidAmount",SqlDbType.Decimal).Value= textBox3.Text;
            cmd1.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox4.Text;
            cmd1.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetails");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = Category.It_Professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }
        public void calculatefees()
        {
           
            if (cat.ToString()=="Student")
            {
                textBox2.Text = "1000";
                float ta=Convert.ToSingle(textBox2.Text);
                fp = ta * 0.5f;
                float amt=Convert.ToSingle(textBox3.Text);
                if(amt<fp)
                {
                    MessageBox.Show("Minimum amount to be paid is 50 per");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if(cat.ToString()=="It_Professional")
            {
                textBox2.Text = "3000";
                float ta=Convert.ToSingle(textBox2.Text);
                 fp = ta * 0.8f;
                float amt=Convert.ToSingle(textBox3.Text);
                if(amt<fp)
                {
                    MessageBox.Show("Minimum amount to be paid is 80 per");

                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text=bamt.ToString();
                }
            }
                
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                cat = Category.Student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            Getnation();
            Getstate();
            Getcity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();


        }
    }
}
