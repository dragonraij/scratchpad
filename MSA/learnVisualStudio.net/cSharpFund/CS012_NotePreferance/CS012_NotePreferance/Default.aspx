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
        <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="noteOptions" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" GroupName="noteOptions" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="noteOptions" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="noteOptions" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" OK " />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
