using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fendhal_Test
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        int total = 0;
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                sb.Append("Please enter order number");
            }
            else
            {
                int OrderNumber = Convert.ToInt32(TextBox1.Text);
                sb.Append("Order Number: " + OrderNumber + "<br>");
            }

            

            string Name = TextBox2.Text;
            string Date=TextBox3.Text;
            total=Convert.ToInt32(TextBox4.Text)*Convert.ToInt32(TextBox5.Text);
           
            sb.Append("Name: " + Name + "<br>");
            sb.Append("Date: " + Date+"<br>");
            sb.Append("Total: " + total + "<br>");
            Label1.Text = sb.ToString();

           
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Mouse")
            {
                TextBox4.Text = "100";
            }
            else if (DropDownList1.Text == "Monitor")
            {
                TextBox4.Text = "200";
            }
            else if (DropDownList1.Text == "Keyboard")
            {
                TextBox5.Text = "300";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}