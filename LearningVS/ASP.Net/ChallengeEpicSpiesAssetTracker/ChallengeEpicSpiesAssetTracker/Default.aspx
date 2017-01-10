<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
            height: 164px;
        }
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="" class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <span class="auto-style2"><strong>Asset Performance Tracker</strong></span><br />
        <br />
        Asset Name: <asp:TextBox ID="assetName" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:
        <asp:TextBox ID="electionsRigged" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuge Performed:
        <asp:TextBox ID="actsOfSubterfuge" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addAsset" runat="server" OnClick="addAsset_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
