<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS019_EpicSpies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            color: #663300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
    
    </div>
        <h3 class="auto-style1">Spy New Assignment Form</h3>
        <p>
            Spy Code Name :
            <asp:TextBox ID="spyNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name :
            <asp:TextBox ID="assignmentNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment :</p>
        <p>
            <asp:Calendar ID="previousCalendar" runat="server" OnSelectionChanged="previousCalendar_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment :</p>
        <p>
            <asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
