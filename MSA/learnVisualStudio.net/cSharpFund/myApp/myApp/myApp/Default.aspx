<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="myApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        FirstName:
        <asp:TextBox ID="firstTxt" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        Last Name:<asp:TextBox ID="lastTxt" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Click me! " />
        <br />
        <asp:Label ID="output" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
