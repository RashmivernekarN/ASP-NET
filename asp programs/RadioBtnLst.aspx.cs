using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RadioBtnLst : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            RadioButtonList1.Items.Add("DTP");
            RadioButtonList1.Items.Add("Ms-Office");
            RadioButtonList1.Items.Add("Tally");
        }
        RadioButtonList1.AutoPostBack = true;
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            Response.Write("U selected course "+RadioButtonList1.Text);
        }
        else if (RadioButtonList1.SelectedIndex == 1)
        {
            Response.Write("U selected course " + RadioButtonList1.Text);
        }
        else if (RadioButtonList1.SelectedItem.Value=="Tally")
        {
            Response.Write("U selected course " + RadioButtonList1.Text);
        }

    }
}