<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManageUsers.aspx.vb" Inherits="ManageUsers" %>

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
            style="z-index: 1; left: 10px; top: 15px; position: absolute" 
            Text="IT HELPDESK"></asp:Label>
        <asp:Label ID="lblUsers" runat="server" 
            style="z-index: 1; left: 116px; top: 77px; position: absolute" 
            Text="User Management"></asp:Label>
        <asp:Button ID="btnStaff" runat="server" 
            style="z-index: 1; left: 114px; top: 151px; position: absolute" 
            Text="Manage Staff" />
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 148px; top: 194px; position: absolute" 
            Text="Back" />
        <asp:Button ID="btnTechs" runat="server" 
            style="z-index: 1; left: 81px; top: 113px; position: absolute" 
            Text="Manage Technicians" />
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
