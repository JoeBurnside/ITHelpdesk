<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManageJobs.aspx.vb" Inherits="ManageJobs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:Button ID="btnGo" runat="server" 
            style="z-index: 1; left: 350px; top: 78px; position: absolute" Text="Go" />
        <asp:Label ID="Logo" runat="server" BackColor="Yellow" BorderColor="#3333CC" 
            Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#3333CC" 
            style="z-index: 1; left: 10px; top: 15px; position: absolute" 
            Text="IT HELPDESK"></asp:Label>
        <asp:Label ID="lblError" runat="server" 
            
            style="z-index: 1; left: 482px; top: 304px; position: absolute; height: 19px;" 
            ForeColor="Red"></asp:Label>
        <asp:Label ID="lblAssign" runat="server" 
            style="z-index: 1; left: 483px; top: 115px; position: absolute" 
            Text="Assign Job"></asp:Label>
        <asp:Label ID="lblStatus" runat="server" 
            style="z-index: 1; left: 168px; top: 82px; position: absolute" Text="Status"></asp:Label>
        <asp:Label ID="lblJobs" runat="server" 
            style="z-index: 1; left: 30px; top: 80px; position: absolute" 
            Text="Jobs"></asp:Label>
        <asp:Button ID="btnAssign" runat="server" 
            style="z-index: 1; left: 527px; top: 188px; position: absolute" Text="Assign" />
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 527px; top: 358px; position: absolute" 
            Text="Back" />
        <asp:Button ID="btnDelete" runat="server" 
            style="z-index: 1; left: 527px; top: 265px; position: absolute" 
            Text="Delete Job" />
        <asp:DropDownList ID="ddlTechs" runat="server" 
            style="z-index: 1; left: 473px; top: 145px; position: absolute">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlStatus" runat="server" 
            style="z-index: 1; left: 219px; top: 81px; position: absolute">
            <asp:ListItem>All</asp:ListItem>
            <asp:ListItem>Pending</asp:ListItem>
            <asp:ListItem>Active</asp:ListItem>
            <asp:ListItem>Complete</asp:ListItem>
        </asp:DropDownList>
    </p>
    <div>
    
    </div>
        <asp:ListBox ID="lstJobs" runat="server" 
            
            
        style="z-index: 1; left: 21px; top: 114px; position: absolute; height: 285px; width: 415px">
        </asp:ListBox>
    </form>
</body>
</html>
