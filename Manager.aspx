<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Manager.aspx.vb" Inherits="Manager" %>

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
        <asp:Label ID="lblManager" runat="server" 
            style="z-index: 1; left: 139px; top: 101px; position: absolute" 
            Text="Managers Menu"></asp:Label>
    </p>
    <div>
    
    </div>
    <asp:Button ID="btnUsers" runat="server" 
        style="z-index: 1; left: 127px; top: 181px; position: absolute" 
        Text="Manage Users" />
    <asp:Button ID="btnJobs" runat="server" 
        style="z-index: 1; left: 145px; top: 140px; position: absolute" 
        Text="View Jobs" />
    <asp:Button ID="btnReports" runat="server" 
        style="z-index: 1; left: 156px; top: 223px; position: absolute" 
        Text="Reports" />
    <asp:Button ID="btnLogout" runat="server" 
        style="z-index: 1; left: 161px; top: 264px; position: absolute" 
        Text="Logout" />
    </form>
</body>
</html>
