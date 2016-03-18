<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StaffEdit.aspx.vb" Inherits="StaffEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
    <p>
        <asp:Label ID="Logo" runat="server" BackColor="Yellow" BorderColor="#3333CC" 
            Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#3333CC" 
            style="z-index: 1; left: 23px; top: 17px; position: absolute" 
            Text="IT HELPDESK"></asp:Label>
    </p>
    <div>
    
    </div>
    <asp:Label ID="lblForename" runat="server" 
        style="z-index: 1; left: 73px; top: 73px; position: absolute; right: 818px" 
        Text="Forename"></asp:Label>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 172px; top: 292px; position: absolute"></asp:Label>
    <asp:Label ID="lblSurname" runat="server" 
        style="z-index: 1; left: 74px; top: 109px; position: absolute" 
         Text="Surname"></asp:Label>
    <asp:Label ID="lblEmail" runat="server" 
        style="z-index: 1; left: 94px; top: 144px; position: absolute" Text="Email"></asp:Label>
    <asp:Label ID="lblPhoneNo" runat="server" 
        style="z-index: 1; left: 69px; top: 180px; position: absolute; height: 19px" 
        Text="PhoneNo"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" 
        style="z-index: 1; left: 67px; top: 215px; position: absolute" 
         Text="Password"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" 
        style="z-index: 1; left: 173px; top: 212px; position: absolute" 
        TextMode="Password"></asp:TextBox>
    <asp:TextBox ID="txtSurname" runat="server" 
        style="z-index: 1; top: 107px; position: absolute; left: 173px"></asp:TextBox>
    <asp:TextBox ID="txtConfirm" runat="server" 
        style="z-index: 1; left: 173px; top: 249px; position: absolute" 
        TextMode="Password"></asp:TextBox>
    <asp:TextBox ID="txtEmail" runat="server" 
        style="z-index: 1; left: 173px; top: 142px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtForename" runat="server" 
        style="z-index: 1; left: 173px; top: 72px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPhoneNo" runat="server" 
        style="z-index: 1; left: 173px; top: 177px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnSubmit" runat="server" 
        style="z-index: 1; left: 106px; top: 322px; position: absolute" Text="Submit" />
    <p>
        &nbsp;</p>
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; top: 322px; position: absolute; left: 197px" Text="Back" />
    <p>
        <asp:Label ID="lblConfirm" runat="server" 
            style="z-index: 1; left: 14px; position: absolute; top: 250px" 
            Text="Confirm Password"></asp:Label>
    </p>
    </form>
</body>
</html>
