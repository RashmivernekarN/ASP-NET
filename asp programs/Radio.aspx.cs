using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Radio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RadioButton1.Text = "BCA";
        RadioButton2.Text = "BBA";
        RadioButton3.Text = "BCOM";
        RadioButton1.GroupName = "gr1";
        RadioButton2.GroupName = "gr1";
        RadioButton3.GroupName = "gr1";
        RadioButton1.AutoPostBack = true;
        RadioButton2.AutoPostBack = true;
        RadioButton3.AutoPostBack = true;
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        TextBox1.Text = "U selected degree " + RadioButton1.Text;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        TextBox1.Text = "U selected degree " + RadioButton2.Text;
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        TextBox1.Text = "U selected degree " + RadioButton3.Text;
    }
}