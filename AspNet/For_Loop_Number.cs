using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace For_Loop_Number
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int num = Convert.ToInt32(TextBox1.Text);
            for( i=1;i<num;i++)
            {
                sb.Append(i + "<br>");
                Label1.Text = sb.ToString();
            }
            

        }
    }
}