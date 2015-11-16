<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS035_PhunWithStrings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reverse" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
        <br />
        <asp:Label ID="Label2" runat="server" Text="[&quot;Leia&quot;, &quot;Luke&quot;, &quot;chewy&quot;, &quot;R2D2&quot;]"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
