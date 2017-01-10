<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeFirstPapBobsWebsite.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style3 {
            color: #FF3300;
        }
        .auto-style4 {
            width: 200px;
            height: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>
        <img alt="Bob" class="auto-style4" src="PapaBob.png" />Papa Bob&#39;s Pizza and Software</strong></div>
        <p>
            <asp:RadioButton ID="rdbSmallSize" runat="server" GroupName="PizzaSize" Text="Baby Bob Size (10&quot;) - $10" />
        </p>
        <p>
            <asp:RadioButton ID="rdbMedSize" runat="server" GroupName="PizzaSize" Text="Mama Bob Size (13&quot;) - $13" />
        </p>
        <p>
            <asp:RadioButton ID="rdbLargeSize" runat="server" GroupName="PizzaSize" Text="Papa Bob Size (16&quot;) - $16" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:RadioButton ID="rdbThinCrust" runat="server" GroupName="Crust" Text="Thin Crust" />
        </p>
        <p>
            <asp:RadioButton ID="rdbDeepDish" runat="server" GroupName="Crust" Text="Deep Dish ( + $2)" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:CheckBox ID="chkPepperoni" runat="server" Text="Pepperoni (+ $1.50)" />
        </p>
        <p>
            <asp:CheckBox ID="chkOnions" runat="server" Text="Onions (+ $0.75)" />
        </p>
        <p>
            <asp:CheckBox ID="chkGreenPeppers" runat="server" Text="Green Pepper" />
            s ( + $0.50)</p>
        <p>
            <asp:CheckBox ID="chkRedPeppers" runat="server" Text="Red Peppers  ( + $0.75)" />
        </p>
        <p>
            <asp:CheckBox ID="chkAnchovies" runat="server" Text="Anchovies ( + $2.00)" />
        </p>
        <p class="auto-style2">
            Papa Bob&#39;s <span class="auto-style3">Special Deal</span></p>
        <p>
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your Pizza</p>
        <p>
            <asp:Button ID="btnPurchase" runat="server" OnClick="btnPurchase_Click" Text="Purchase" />
        </p>
        <p>
            Total:&nbsp; <asp:Label ID="lblTotal" runat="server" Text="$0.00"></asp:Label>
        </p>
        <p>
            Sorry, at this time you can only order one pizza online, and pick-up only... we need a better website!</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
