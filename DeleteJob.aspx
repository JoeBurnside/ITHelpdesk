<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DeleteJob.aspx.vb" Inherits="DeleteJob" %>

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
        <asp:Button ID="btnDelete" runat="server" 
            style="z-index: 1; left: 74px; top: 162px; position: absolute; right: 823px" 
            Text="Delete" />
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 145px; top: 162px; position: absolute" Text="Back" />
        <asp:Label ID="lblConfirm" runat="server" 
            style="z-index: 1; left: 59px; top: 90px; position: absolute"></asp:Label>
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
