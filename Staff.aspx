<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Staff.aspx.vb" Inherits="Staff" %>

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
        <asp:Label ID="lblStaff" runat="server" 
            style="z-index: 1; left: 135px; top: 86px; position: absolute" 
            Text="Staff Menu"></asp:Label>
    </p>
    <div>
    
    </div>
    <asp:Button ID="btnChange" runat="server" 
        style="z-index: 1; left: 82px; top: 197px; position: absolute" 
        Text="Change your Details" />
    <asp:Button ID="btnLogout" runat="server" 
        style="z-index: 1; left: 142px; top: 235px; position: absolute" Text="Logout" />
    <asp:Button ID="btnRequests" runat="server" 
        style="z-index: 1; left: 81px; top: 160px; position: absolute" 
        Text="View Your Requests" />
    <asp:Button ID="btnLog" runat="server" 
        style="z-index: 1; left: 127px; top: 125px; position: absolute" 
        Text="Log Fault" />
    </form>
</body>
</html>
