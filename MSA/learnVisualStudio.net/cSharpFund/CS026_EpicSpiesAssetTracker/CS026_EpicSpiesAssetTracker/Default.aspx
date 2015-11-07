<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS026_EpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            color: #663300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <br />
        <h2 class="auto-style1">Asset Performance Tracker</h2>
        <br />
        Asset Name :
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        Elections Rigged :
        <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        <br />
        Acts of Subterfuge Performed :
        <asp:TextBox ID="subterfugeTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="asset" runat="server" Text="Add Asset" />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
