<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS034_Postage_Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            color: #CC0066;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 class="auto-style1">Postage Calculator</h2>
        Width:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="inputChanged"></asp:TextBox>
        <br />
        Height:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="inputChanged"></asp:TextBox>
        <br />
        Length:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="inputChanged"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="shippingMethod" OnCheckedChanged="inputChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" GroupName="shippingMethod" OnCheckedChanged="inputChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="shippingMethod" OnCheckedChanged="inputChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" Text="rer"></asp:Label>
    
    </div>
    </form>
</body>
</html>
