<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS051_WarGame.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="titleLabel" runat="server" Font-Names="Blackadder ITC" Font-Size="XX-Large" ForeColor="#CC0000" Text="War Games"></asp:Label>
        <br />
        <asp:Label ID="vsLabel" runat="server" Text="vs"></asp:Label>
        <br />
        <asp:Label ID="dealLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="battleLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
