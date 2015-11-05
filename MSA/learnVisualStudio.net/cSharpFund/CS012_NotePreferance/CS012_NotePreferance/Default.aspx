<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS012_NotePreferance.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Your Note Taking Preferance<br />
        <br />
        <asp:RadioButton ID="pencilRadioButton" runat="server" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text=" OK " />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
