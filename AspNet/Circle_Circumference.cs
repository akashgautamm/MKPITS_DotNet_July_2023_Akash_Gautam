using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Circle_Circumference
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float circum = 0;
            float circle = 0;
            float radius = Convert.ToSingle(TextBox1.Text);
            circle = 3.140f * radius * radius;
            circum = 2 * 3.140f * radius;
            Label1.Text=circum.ToString();
            Label2.Text=circle.ToString();

        }
    }
}