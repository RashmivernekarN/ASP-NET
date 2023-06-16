using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Placeholder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label Lbl;
        Lbl = new Label();
        Lbl.Text = "Label created during run time";
        Lbl.ForeColor = System.Drawing.Color.Blue;
        PlaceHolder1.Controls.Add(Lbl);

        Calendar Cal;
        Cal = new Calendar();
        PlaceHolder1.Controls.Add(Cal);
    }
}