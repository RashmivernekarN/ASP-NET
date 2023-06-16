<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDown.aspx.cs" Inherits="DropDown" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="218px">
        </asp:DropDownList>
    
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
