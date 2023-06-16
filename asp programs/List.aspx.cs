using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ListBox1.Items.Add("Cricket");
            ListBox1.Items.Add("FootBall");
            ListBox1.Items.Add("VolleyBall");
        }
        ListBox1.AutoPostBack = true;
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ListBox1.SelectedIndex == 0)
        {
            TextBox1.Text = "U selected sports "+ListBox1.Text;
        }
        else if (ListBox1.SelectedIndex == 1)
        {
            TextBox1.Text = "U selected sports " + ListBox1.Text;
        }
        else if (ListBox1.SelectedIndex == 2)
        {
            TextBox1.Text = "U selected sports " + ListBox1.Text;
        }
    }
}