using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CheckBox1.Text = "Passed/Failed";
        CheckBox1.AutoPostBack = true;
        Label1.Text = "";
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            Label1.Text = "Congrats well done";
            Label1.ForeColor = System.Drawing.Color.Blue;
            CheckBox1.Text = "Passed";
            CheckBox1.ForeColor = System.Drawing.Color.Blue;
        }
        else
        {
            Label1.Text = "Better try next time";
            Label1.ForeColor = System.Drawing.Color.Red;
            CheckBox1.Text = "Failed";
            CheckBox1.ForeColor = System.Drawing.Color.Red;
        }
    }
}