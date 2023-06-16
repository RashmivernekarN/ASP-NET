<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Drop_List.aspx.cs" Inherits="Drop_List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="190px">
        </asp:DropDownList>
        <br />
    
    </div>
    <asp:ListBox ID="ListBox1" runat="server" Height="180px" Width="191px">
    </asp:ListBox>
    </form>
</body>
</html>
