using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDown : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            DropDownList1.Items.Add("C");
            DropDownList1.Items.Add("C++");
            DropDownList1.Items.Add("C#");
        }
        DropDownList1.AutoPostBack = true;
        Label1.Text = "";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            Label1.Text = "U selected course "+DropDownList1.Text;
        }
        else if (DropDownList1.SelectedIndex == 1)
        {
            Label1.Text = "U selected course " + DropDownList1.Text;
        }
        else
        {
            Label1.Text = "U selected course " + DropDownList1.Text;
        }
    }
}