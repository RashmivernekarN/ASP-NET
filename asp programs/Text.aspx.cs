using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Text : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = "KEONICS";
        TextBox2.Text = "COMPUTER";
        TextBox3.Text = "CENTRE";
    }
    protected void BtnRead_Click(object sender, EventArgs e)
    {
        TextBox1.ReadOnly = !TextBox1.ReadOnly;
    }
    protected void BtnVisible_Click(object sender, EventArgs e)
    {
        TextBox2.Visible = !TextBox2.Visible;
    }
    protected void BtnEnable_Click(object sender, EventArgs e)
    {
        TextBox3.Enabled = !TextBox3.Enabled;
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }
    protected void BtnColor_Click(object sender, EventArgs e)
    {
        TextBox1.BackColor = System.Drawing.Color.Yellow;
    }

   
}