<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadioBtnLst.aspx.cs" Inherits="RadioBtnLst" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
        </asp:RadioButtonList>
    
    </div>
    </form>
</body>
</html>
