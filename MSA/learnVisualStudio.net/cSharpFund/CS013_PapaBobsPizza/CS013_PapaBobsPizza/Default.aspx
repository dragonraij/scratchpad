<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS013_PapaBobsPizza.Default" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bobs Pizza</title>
    <style type="text/css">
        .auto-style1 {
            color: #FF9933;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style3 {
            background-color: #CC0066;
        }
        .auto-style4 {
            background-color: #FF9966;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" visible="False">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/assets/PapaBob.png" />
        <h1><span class="auto-style2">Papa Bob&#39;s Pizza and Software</span></h1>
    
    </div>
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="size" Text="Baby Bob Size (10'') - $10" />
        <br />
        <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="size" Text="Mama Bob Size (13'') - $13" />
        <br />
        <asp:RadioButton ID="papaRadioButton" runat="server" GroupName="size" Text="Papa Bob Size (16'') - $16" />
        <br />
        <br />
        <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="crust" Text="Thin Crust" />
        <br />
        <asp:RadioButton ID="deepRadioButton" runat="server" GroupName="crust" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenPeppersCheckBox" runat="server" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redPeppersCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
        <br />
        <h3 style="height: 21px"><span class="auto-style2">Papa Bob&#39;s&nbsp; </span><span class="auto-style1">Special Deal</span><br />
        </h3>
        <span class="auto-style3"><strong><span class="auto-style4">Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onion to your pizza</span></strong></span><br />
        <br />
        <asp:Button ID="purchaceButton" runat="server" OnClick="purchaceButton_Click" Text="Purchace" />
        <br />
        <br />
        Total :
        <asp:Label ID="totalLabel" runat="server" style="font-weight: 700; font-family: Arial, Helvetica, sans-serif" Text="$0.00"></asp:Label>
&nbsp;
        <asp:Label ID="Label2" runat="server" style="font-family: Arial, Helvetica, sans-serif; color: #FF9933; font-style: italic" Text="(Discount Applied)"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pickup only, we need a better website!!<br />
    </form>
</body>
</html>
