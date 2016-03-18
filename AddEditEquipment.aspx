<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddEditEquipment.aspx.vb" Inherits="AddEditEquipment" %>

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
        <asp:TextBox ID="txtModel" runat="server" 
            style="z-index: 1; left: 193px; top: 163px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtLocation" runat="server" 
            style="z-index: 1; left: 193px; top: 89px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtDescription" runat="server" 
            style="z-index: 1; left: 193px; top: 203px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:TextBox ID="txtMake" runat="server" 
            style="z-index: 1; left: 193px; top: 125px; position: absolute" 
            MaxLength="50"></asp:TextBox>
        <asp:Label ID="lblModel" runat="server" 
            style="z-index: 1; left: 76px; top: 166px; position: absolute; bottom: 145px" 
            Text="Model"></asp:Label>
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 154px; top: 244px; position: absolute"></asp:Label>
        <asp:Label ID="lblLocation" runat="server" 
            style="z-index: 1; left: 63px; top: 91px; position: absolute" Text="Location"></asp:Label>
        <asp:Label ID="lblMake" runat="server" 
            style="z-index: 1; left: 78px; top: 127px; position: absolute; width: 38px;" 
            Text="Make"></asp:Label>
        <asp:Label ID="lblDescription" runat="server" 
            style="z-index: 1; left: 47px; top: 204px; position: absolute" 
            Text="Description"></asp:Label>
        <asp:Button ID="btnSubmit" runat="server" 
            style="z-index: 1; left: 97px; top: 282px; position: absolute" Text="Submit" />
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 190px; top: 282px; position: absolute" Text="Back" />
    </p>
    <div>
    
    </div>
    </form>
</body>
</html>
