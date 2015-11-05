<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS010_SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
        <br />
        <span class="auto-style1">First Number :</span>
        <asp:TextBox ID="FirstTextBox" runat="server"></asp:TextBox>
        <br />
        <span class="auto-style1">Second Number :</span>
        <asp:TextBox ID="SecondTextBox" runat="server" TabIndex="1"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" TabIndex="2" Text=" + " />
&nbsp;
        <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" TabIndex="2" Text=" - " />
&nbsp;&nbsp;
        <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" TabIndex="4" Text=" * " />
&nbsp;&nbsp;
        <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" TabIndex="5" Text=" / " />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#FFFFCC" Font-Bold="True" Font-Names="Arial"></asp:Label>
    
    </div>
    </form>
</body>
</html>
