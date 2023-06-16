using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        Label1.Text = "Enter User Name and Password";
    }
    protected void BtnReset_Click(object sender, EventArgs e)
    {
        Label1.Text = "Enter User Name and Password";
    }
}