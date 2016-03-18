<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LogFault.aspx.vb" Inherits="LogFault" %>

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
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 136px; top: 215px; position: absolute"></asp:Label>
        <asp:Label ID="lblMachineNo" runat="server" 
            style="z-index: 1; left: 27px; top: 125px; position: absolute; right: 1012px" 
            Text="Machine Number"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" 
            style="z-index: 1; left: 12px; top: 177px; position: absolute" 
            Text="Description of Fault"></asp:Label>
        <asp:DropDownList ID="ddlMachine" runat="server" 
            style="z-index: 1; left: 151px; top: 123px; position: absolute">
        </asp:DropDownList>
        <asp:TextBox ID="txtDescription" runat="server" 
            style="z-index: 1; left: 151px; top: 175px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" 
            style="z-index: 1; left: 85px; top: 248px; position: absolute" 
            Text="Log Fault" />
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 181px; top: 248px; position: absolute" Text="Back" />
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
