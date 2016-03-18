<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ReportForm.aspx.vb" Inherits="ReportForm" %>

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
        <asp:Label ID="lblTitle" runat="server" 
            style="z-index: 1; left: 26px; top: 85px; position: absolute"></asp:Label>
        <asp:Label ID="lblSubject" runat="server" 
            style="z-index: 1; left: 28px; top: 129px; position: absolute; height: 19px"></asp:Label>
    
    </div>
    <asp:Table ID="tblReport" runat="server" 
        style="z-index: 1; left: 35px; top: 181px; position: absolute; height: 25px; width: 30px">
    </asp:Table>
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 360px; top: 84px; position: absolute" Text="Back" />
    </form>
</body>
</html>
