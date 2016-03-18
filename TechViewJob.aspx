<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TechViewJob.aspx.vb" Inherits="TechViewJob" %>

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
        <asp:Label ID="lblStaff" runat="server" 
            style="z-index: 1; left: 79px; top: 143px; position: absolute"></asp:Label>
        <asp:Label ID="lblLocation" runat="server" 
            style="z-index: 1; left: 79px; top: 111px; position: absolute"></asp:Label>
        <asp:Label ID="lblDate" runat="server" 
            style="z-index: 1; left: 79px; top: 214px; position: absolute"></asp:Label>
        <asp:Label ID="lblEquipment" runat="server" 
            style="z-index: 1; left: 79px; top: 80px; position: absolute"></asp:Label>
        <asp:Label ID="lblConfirm" runat="server" 
            style="z-index: 1; left: 79px; position: absolute; top: 252px"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" 
            style="z-index: 1; left: 79px; top: 176px; position: absolute"></asp:Label>
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 222px; top: 288px; position: absolute" 
            Text="Back" />
        <asp:Button ID="btnTake" runat="server" 
            style="z-index: 1; left: 121px; top: 288px; position: absolute" 
            Text="Take Job" />
    
    </div>
    </form>
</body>
</html>
