<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS051_StudentCourses.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="AssignmentButton1" runat="server" OnClick="AssignmentButton1_Click" Text="Assignment1" />
        <br />
        <br />
        <asp:Button ID="AssignmentButton2" runat="server" OnClick="Button2_Click" Text="Assignment2" />
        <br />
        <br />
        <asp:Button ID="AssignmentButton3" runat="server" OnClick="AssignmentButton3_Click" Text="Assignment3" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
