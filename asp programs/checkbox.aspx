<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkbox.aspx.cs" Inherits="checkbox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            font-weight: bold;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="style1" 
            oncheckedchanged="CheckBox1_CheckedChanged" />
    
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label1" runat="server" CssClass="style1" Text="Label"></asp:Label>
    </form>
</body>
</html>
