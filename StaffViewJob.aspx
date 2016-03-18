<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StaffViewJob.aspx.vb" Inherits="StaffViewJob" %>

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
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 132px; top: 308px; position: absolute" Text="Back" />
        <asp:Label ID="lblStatus" runat="server" 
            style="z-index: 1; left: 63px; top: 206px; position: absolute"></asp:Label>
        <asp:Label ID="lblTechnician" runat="server" 
            style="z-index: 1; left: 63px; top: 177px; position: absolute"></asp:Label>
        <asp:Label ID="lblAction" runat="server" 
            style="z-index: 1; left: 63px; top: 238px; position: absolute"></asp:Label>
        <asp:Label ID="lblMachine" runat="server" 
            style="z-index: 1; left: 63px; top: 91px; position: absolute"></asp:Label>
        <asp:Label ID="lblDaterequested" runat="server" 
            
            style="z-index: 1; left: 63px; top: 150px; position: absolute"></asp:Label>
        <asp:Label ID="lblLocation" runat="server" 
            style="z-index: 1; left: 63px; top: 122px; position: absolute"></asp:Label>
        <asp:Label ID="lblDatecompleted" runat="server" 
            style="z-index: 1; left: 63px; top: 270px; position: absolute"></asp:Label>
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
