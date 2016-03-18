<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Technician.aspx.vb" Inherits="Technician" %>

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
        <asp:Button ID="btnLogout" runat="server" 
            style="z-index: 1; left: 142px; top: 276px; position: absolute" 
            Text="Logout" />
        <asp:Button ID="btnAvailable" runat="server" 
            style="z-index: 1; left: 85px; top: 153px; position: absolute" 
            Text="View Available Jobs" />
        <asp:Button ID="btnEquipment" runat="server" 
            style="z-index: 1; left: 83px; top: 236px; position: absolute" 
            Text="Equipment Manager" />
        <asp:Button ID="btnYour" runat="server" 
            style="z-index: 1; left: 103px; top: 194px; position: absolute" 
            Text="View Your Jobs" />
        <asp:Label ID="lblTechnicians" runat="server" 
            style="z-index: 1; left: 118px; top: 100px; position: absolute" 
            Text="Technicians Menu"></asp:Label>
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
