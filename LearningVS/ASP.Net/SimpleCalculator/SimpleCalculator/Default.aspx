<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Simple Calculator</h2>
        <p>
            <span class="auto-style1">First Value </span>&nbsp;
            <asp:TextBox ID="firstValue" runat="server"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style1">Second Value </span>&nbsp;
            <asp:TextBox ID="secondValue" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="+" />
&nbsp;
            <asp:Button ID="btnSubtract" runat="server" Text="-" OnClick="btnSubtract_Click" />
&nbsp;
            <asp:Button ID="btnMultiply" runat="server" Text="*" OnClick="btnMultiply_Click" />
&nbsp;
            <asp:Button ID="btnDivide" runat="server" Text="/" OnClick="btnDivide_Click" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" BackColor="#33CCFF" Font-Bold="True" style="font-size: large"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
