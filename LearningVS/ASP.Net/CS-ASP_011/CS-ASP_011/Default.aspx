<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp; equal to
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are you cool?" />
        <br />
        <br />
        What food would you choose?<br />
        <asp:RadioButton ID="pizza" runat="server" Checked="True" GroupName="FoodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="salad" runat="server" GroupName="FoodGroup" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Salad" />
        <br />
        <asp:RadioButton ID="pbj" runat="server" GroupName="FoodGroup" Text="Peanut Butter and Jelly" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
