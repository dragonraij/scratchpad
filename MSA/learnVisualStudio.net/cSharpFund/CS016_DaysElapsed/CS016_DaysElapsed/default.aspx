<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS016_DaysElapsed._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How many days have elapsed?<br />
        <br />
        Choose one date:<br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        Choose another date:<br />
        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="differenceButton" runat="server" OnClick="differenceButton_Click" Text="Diffrence" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
