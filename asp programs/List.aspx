<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" Height="187px" 
            onselectedindexchanged="ListBox1_SelectedIndexChanged" Width="219px">
        </asp:ListBox>
    
    </div>
    <p>
        &nbsp;</p>
    <asp:TextBox ID="TextBox1" runat="server" Width="630px"></asp:TextBox>
    </form>
</body>
</html>
