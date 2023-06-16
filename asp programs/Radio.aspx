<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Radio.aspx.cs" Inherits="Radio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="RadioButton1" runat="server" 
            oncheckedchanged="RadioButton1_CheckedChanged" />
        <br />
    
    </div>
    <p>
        <asp:RadioButton ID="RadioButton2" runat="server" 
            oncheckedchanged="RadioButton2_CheckedChanged" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:RadioButton ID="RadioButton3" runat="server" 
            oncheckedchanged="RadioButton3_CheckedChanged" />
    </p>
    <p>
        &nbsp;</p>
    <asp:TextBox ID="TextBox1" runat="server" Width="532px"></asp:TextBox>
    </form>
</body>
</html>
