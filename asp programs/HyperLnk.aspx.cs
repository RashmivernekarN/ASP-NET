using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HyperLnk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HyperLink1.Text = "Click Here";
        HyperLink1.NavigateUrl = "Text.aspx";
    }
}