using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Drop_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            DropDownList1.Items.Add("India");
            DropDownList1.Items.Add("Aus");
        }
        DropDownList1.AutoPostBack = true;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            ListBox1.Items.Clear();
            ListBox1.Items.Add("Kohli");
            ListBox1.Items.Add("Dhoni");
            ListBox1.Items.Add("Rohit");
        }
        else
        {
            ListBox1.Items.Clear();
            ListBox1.Items.Add("Mathew");
            ListBox1.Items.Add("Clark");
            ListBox1.Items.Add("Michel");
        }
    }
}