using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class label2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "KEONICS";
        Label1.Font.Size = 36;
        Label1.Font.Name = "Arial Black";
        Label1.ForeColor = System.Drawing.Color.Blue;
        Label1.Font.Bold = true;
        Label1.Font.Underline = true;

    }
}