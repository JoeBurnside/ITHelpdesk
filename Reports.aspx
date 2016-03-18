<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Reports.aspx.vb" Inherits="Reports" %>

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
    </p>
    <div>
    
    </div>
    <asp:Label ID="lblStaff" runat="server" 
        style="z-index: 1; left: 67px; top: 101px; position: absolute" Text="By Staff"></asp:Label>
    <asp:Label ID="lblEquipment" runat="server" 
        style="z-index: 1; left: 32px; top: 233px; position: absolute" 
        Text="Equipment History"></asp:Label>
    <asp:Label ID="lblReports" runat="server" 
        style="z-index: 1; left: 12px; top: 68px; position: absolute" 
        Text="Reports Menu"></asp:Label>
    <asp:Label ID="lblStatus" runat="server" 
        style="z-index: 1; left: 70px; top: 183px; position: absolute; right: 824px" 
        Text="By Status"></asp:Label>
    <asp:Label ID="lblTechs" runat="server" 
        style="z-index: 1; left: 50px; top: 142px; position: absolute; height: 19px" 
        Text="By Technician"></asp:Label>
    <asp:DropDownList ID="ddlEquipment" runat="server" 
        style="z-index: 1; left: 151px; top: 231px; position: absolute">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlStaff" runat="server" 
        style="z-index: 1; left: 150px; top: 99px; position: absolute">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlStatus" runat="server" 
        style="z-index: 1; left: 152px; top: 182px; position: absolute; right: 723px">
    </asp:DropDownList>
    <asp:DropDownList ID="ddlTech" runat="server" 
        style="z-index: 1; left: 151px; top: 140px; position: absolute">
    </asp:DropDownList>
    <asp:Button ID="btnEquipment" runat="server" 
        style="z-index: 1; left: 306px; top: 226px; position: absolute" Text="Go" />
    <asp:Button ID="btnStatus" runat="server" 
        style="z-index: 1; left: 305px; top: 180px; position: absolute" Text="Go" />
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 148px; top: 288px; position: absolute" Text="Back" />
    <asp:Button ID="btnStaff" runat="server" 
        style="z-index: 1; left: 304px; top: 96px; position: absolute" Text="Go" />
    <asp:Button ID="btnTech" runat="server" 
        style="z-index: 1; left: 303px; top: 137px; position: absolute" Text="Go" />
    </form>
</body>
</html>
