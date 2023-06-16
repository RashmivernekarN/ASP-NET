using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Panel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox Txt;
        Txt = new TextBox();
        Txt.Text = "Text box created during run time";
        Txt.ForeColor = System.Drawing.Color.Blue;
        Panel1.Controls.Add(Txt);

        CheckBox chk;
        chk = new CheckBox();
        chk.Text = "Passed/Failed";
        chk.ForeColor=System.Drawing.Color.Red;
        Panel1.Controls.Add(chk);

    }
}