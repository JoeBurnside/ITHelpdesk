<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Index.aspx.vb" Inherits="Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Logo" runat="server" BackColor="Yellow" BorderColor="#3333CC" 
            Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#3333CC" 
            style="z-index: 1; left: 10px; top: 15px; position: absolute" 
            Text="IT HELPDESK"></asp:Label>
    
    </div>
    <asp:Label ID="lblLogin" runat="server" 
        style="z-index: 1; left: 127px; top: 99px; position: absolute" 
        Text="Please Login to continue"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" 
        style="z-index: 1; left: 21px; top: 187px; position: absolute" 
        Text="Password"></asp:Label>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 175px; top: 284px; position: absolute"></asp:Label>
    <asp:Label ID="lblEmail" runat="server" 
        style="z-index: 1; left: 48px; top: 150px; position: absolute" Text="Email"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" 
        
        style="z-index: 1; left: 142px; top: 184px; position: absolute; width: 133px;" 
        TextMode="Password"></asp:TextBox>
    <asp:TextBox ID="txtEmail" runat="server" 
        
        style="z-index: 1; left: 142px; top: 148px; position: absolute; width: 132px;"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" 
        style="z-index: 1; left: 181px; top: 233px; position: absolute" Text="Login" />
    </form>
</body>
</html>
