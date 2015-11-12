<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS034_SlotMachine.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            color: #CC3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style2">SuperSlots</h1>
        <asp:Image ID="reelImage1" runat="server" BorderColor="#FF3300" BorderStyle="Solid" />
        <asp:Image ID="reelImage2" runat="server" BorderColor="#FF3300" BorderStyle="Solid" />
        <asp:Image ID="reelImage3" runat="server" BorderColor="#FF3300" BorderStyle="Solid" />
        <br />
    
        <asp:Label ID="img1Label" runat="server" Text="img1"></asp:Label>
        <asp:Label ID="img2Label" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="img3Label" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Your bet:
        <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" Text="Spin the wheel" OnClick="leverButton_Click" />
        <br />
        <br />
        <asp:Label ID="winningsLabel" runat="server" Text="Your winnings was $0"></asp:Label>
        <br />
        <br />
        <asp:Label ID="balanceLabel" runat="server" Text="Your balance is : $100"></asp:Label>
        <br />
        <strong>
        <br class="auto-style2" />
        </strong><span class="auto-style2"><strong>1 Cherry - 2x your bet </strong></span><strong> <br class="auto-style2"/> </strong><span class="auto-style2"><strong>2 Cherry - 3x your bet </strong></span><strong> <br class="auto-style2"/> </strong><span class="auto-style2"><strong>3 Cherry - 4x your bet
        </strong></span><strong>
        <br class="auto-style2"/> </strong><span class="auto-style2"><strong>3 7's - 100x your bet</strong></span><strong><br class="auto-style2"/></strong><span class="auto-style2"><strong>However if you have even one BAR, you win nothing :(
        </strong></span><strong>
        <br class="auto-style2" />
    
        </strong>
    
    </div>
    </form>
</body>
</html>
