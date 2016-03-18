<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewRequests.aspx.vb" Inherits="ViewRequests" %>

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
        <asp:Label ID="lblJobs" runat="server" 
            style="z-index: 1; left: 27px; top: 76px; position: absolute" Text="Jobs"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 419px; top: 138px; position: absolute"></asp:Label>
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 434px; top: 238px; position: absolute" 
            Text="Back" />
        <asp:Button ID="btnView" runat="server" 
            style="z-index: 1; left: 434px; top: 186px; position: absolute" 
            Text="View Job" />
        <asp:ListBox ID="lstJobs" runat="server" 
            style="z-index: 1; left: 21px; top: 107px; position: absolute; height: 229px; width: 359px">
        </asp:ListBox>
    
    </div>
    </form>
</body>
</html>
