<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManageStaff.aspx.vb" Inherits="ManageStaff" %>

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
            style="z-index: 1; left: 17px; top: 66px; position: absolute" 
            Text="Staff"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 358px; top: 100px; position: absolute"></asp:Label>
        <asp:ListBox ID="lstStaff" runat="server" 
            
            style="z-index: 1; left: 11px; top: 90px; position: absolute; height: 237px; width: 300px">
        </asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" 
            style="z-index: 1; left: 358px; top: 222px; position: absolute" 
            Text="Delete" />
        <asp:Button ID="btnAdd" runat="server" 
            
            style="z-index: 1; left: 358px; top: 134px; position: absolute" 
            Text="Add" />
        <asp:Button ID="btnEdit" runat="server" 
            style="z-index: 1; left: 358px; top: 177px; position: absolute" 
            Text="Edit" />
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 358px; top: 287px; position: absolute" 
            Text="Back" />
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
