<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 242px;
            height: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img alt="Epic Spies Logo" class="auto-style1" src="epic-spies-logo.jpg" style="height: 190px; width: auto;" /><br />
        Spy New Assignement Form</div>
        <p>
            Spy Code Name:&nbsp;
            <asp:TextBox ID="txtCodeName" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignement Name:&nbsp;
            <asp:TextBox ID="txtAssignment" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment:<asp:Calendar ID="calEndDate" runat="server" OnSelectionChanged="calEndDate_SelectionChanged"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:<asp:Calendar ID="calStartDate" runat="server"></asp:Calendar>
        </p>
        <p>
            Projected End Date of New Assignment:<asp:Calendar ID="calProjectedEndDate" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="btnAssign" runat="server" OnClick="btnAssign_Click" Text="Assign Spy" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
