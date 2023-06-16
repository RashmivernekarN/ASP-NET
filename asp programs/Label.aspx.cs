using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Label : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "KEONICS COMPUTER CENTRE";
        Label1.ForeColor= System.Drawing.Color.Blue;
        Label1.BackColor = System.Drawing.Color.Yellow;
        Label1.Font.Size = 36;
        Label1.Font.Name = "Times New Roman";
        Label1.BorderStyle = BorderStyle.Double;
        Label1.BorderColor = System.Drawing.Color.Red;
        Label1.Font.Bold = true;
        Label1.Font.Italic = true;
    }
   
}