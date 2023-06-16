using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calendar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Calendar1_SelectionChanged1(object sender, EventArgs e)
    {
        Response.Write("U selected date is " + Calendar1.SelectedDate.ToShortDateString());
    }
}