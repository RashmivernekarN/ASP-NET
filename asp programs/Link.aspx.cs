using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Link : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton1.Text = "Click here";
    }
   
    protected void LinkButton1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Label.aspx");
    }
}