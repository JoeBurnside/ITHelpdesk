<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddEditTechs.aspx.vb" Inherits="AddEditTechs" %>

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
            style="z-index: 1; left: 23px; top: 17px; position: absolute" 
            Text="IT HELPDESK"></asp:Label>
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 268px; top: 371px; position: absolute" Text="Back" />
        <asp:Button ID="btnSubmit" runat="server" 
            style="z-index: 1; left: 167px; top: 371px; position: absolute" 
            Text="Submit" />
        <asp:Label ID="lblPassword" runat="server" 
            style="z-index: 1; left: 114px; top: 247px; position: absolute" 
            Text="Password"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" 
            style="z-index: 1; left: 141px; top: 206px; position: absolute;" 
            Text="Email"></asp:Label>
        <asp:Label ID="lblSurname" runat="server" 
            style="z-index: 1; left: 121px; top: 121px; position: absolute" 
            Text="Surname"></asp:Label>
        <asp:Label ID="lblConfirm" runat="server" 
            style="z-index: 1; left: 61px; top: 283px; position: absolute" 
            Text="Confirm Password"></asp:Label>
        <asp:Label ID="lblForename" runat="server" 
            style="z-index: 1; left: 113px; top: 85px; position: absolute; height: 19px" 
            Text="Forename"></asp:Label>
        <asp:Label ID="lblPosition" runat="server" 
            style="z-index: 1; left: 126px; top: 162px; position: absolute" 
            Text="Position"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 223px; top: 332px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtSurname" runat="server" 
            
            style="z-index: 1; left: 185px; top: 119px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" 
            style="z-index: 1; left: 185px; top: 244px; position: absolute" 
            TextMode="Password" MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" 
            style="z-index: 1; left: 185px; top: 204px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtForename" runat="server" 
            style="z-index: 1; left: 185px; top: 83px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtConfirm" runat="server" 
            style="z-index: 1; left: 185px; top: 282px; position: absolute" 
            TextMode="Password" MaxLength="50"></asp:TextBox>
        <asp:DropDownList ID="ddlPosition" runat="server" 
            style="z-index: 1; left: 185px; top: 161px; position: absolute">
            <asp:ListItem>Manager</asp:ListItem>
            <asp:ListItem>Technician</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
