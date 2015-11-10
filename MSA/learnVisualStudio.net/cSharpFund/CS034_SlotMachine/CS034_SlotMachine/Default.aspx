<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS034_SlotMachine.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #CC9900;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3 class="auto-style1">SuperSlots</h3>
        <br />
    
        <asp:Label ID="img1Label" runat="server" Text="img1"></asp:Label>
        <asp:Label ID="img2Label" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="img3Label" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Your bet:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" Text="Button" />
        <br />
        <br />
        <asp:Label ID="winningsLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        1 Cherry - 2x your bet <br/> 2 Cherry - 3x your bet <br/> 3 Cherry - 4x your bet
        <br/> 3 7's - 100x your bet<br/>However if you have even one BAR, you win nothing :(
        <br />
    
    </div>
    </form>
</body>
</html>
