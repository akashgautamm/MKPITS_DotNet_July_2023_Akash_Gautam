using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employe_Salary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name;
            string designation;
            float salary;
            float hra = 0;
            float da = 0;
            name = TextBox1.Text;
            float total = 0;
            salary = Convert.ToInt32(TextBox2.Text);
            designation = TextBox3.Text;
            if(designation=="Manager")
            {
                hra = salary * 0.45f;
                da = salary * 0.35f;
                total = salary + hra + da;
            }
            else if(designation=="Peon")
            {
                hra = salary * 0.25f;
                da = salary * 0.15f;
                total = salary + hra + da;

            }
            Label1.Text = hra.ToString();
            Label2.Text = da.ToString();
            Label3.Text = total.ToString();
        }
    }
}