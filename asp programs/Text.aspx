<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Text.aspx.cs" Inherits="Text" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-size: medium;
            color: #9966FF;
        }
    </style>
</head>
<body style="color: #3366FF">
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" CssClass="style1" 
            ></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="style1"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" CssClass="style1"></asp:TextBox>
    
    </div>
    <p>
        &nbsp;</p>
    <asp:Button ID="BtnRead" runat="server" CssClass="style1" 
        onclick="BtnRead_Click" Text="ReadOnly" Font-Bold="True" 
        Font-Italic="True" ForeColor="Blue" />
&nbsp;<asp:Button ID="BtnVisible" runat="server" CssClass="style1" 
        onclick="BtnVisible_Click" Text="Visible" />
&nbsp;<asp:Button ID="BtnEnable" runat="server" CssClass="style1" 
        onclick="BtnEnable_Click" Text="Enable" />
&nbsp;<asp:Button ID="BtnClear" runat="server" CssClass="style1" 
        onclick="BtnClear_Click" Text="Clear" />
&nbsp;<asp:Button ID="BtnColor" runat="server" CssClass="style1" 
        onclick="BtnColor_Click" Text="BackColor" />
&nbsp;</form>
</body>
</html>
