<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>      </title>
    <style type="text/css">
        .style1
        {
            width: 30%;
            height: 81px;
        }
    </style>
    </head>
   <body bgcolor="teal">
         <form id="form1" runat="server">
         <center>
                 <table border="1" bgcolor="sky blue">
	   <tr>
	            <td><img src="kleit_head.png" width="1200"></td>
	   </tr>
	   <tr>
	            <td align="center"><b>
		<a href="Home.html">Home|</a>
		<a href="About.html">About|</a>
		<a href="Courses.html">Courses|</a>
		<a href="Facilities.html">Facilities|</a>
		<a href="Contact.html">Contact</a>
		</b>
	            </td>
	   </tr>
	   <tr>
	            <td>
		            <table bgcolor="#00FFCC" border="1" class="style1">
                        <tr>
                            <td colspan="2">
                                Login Page</td>
                        </tr>
                        <tr>
                            <td align="right">
                                User Name</td>
                            <td align="left">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                Password</td>
                            <td align="left">
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Button ID="BtnLogin" runat="server" BackColor="#66CCFF" 
                                    onclick="BtnLogin_Click" Text="Login" />
                            </td>
                            <td align="left">
                                <asp:Button ID="BtnReset" runat="server" BackColor="#66CCFF" 
                                    onclick="BtnReset_Click" Text="Reset" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>
&nbsp;</td>
	   </tr>
	   <tr>
	            <td width="1200">
		<marquee behavior="alternate">
		<h2>KLE INSTITUTE OF ENGINEERING</h2></marquee>
	            </td>
	   </tr>
                 </table>
         </center>
         </form>
   </body>
</html>
