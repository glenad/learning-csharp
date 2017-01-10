<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 96px;
            height: 64px;
        }
        .auto-style2 {
            font-family: Cambria, Cochin, Georgia, Times, "Times New Roman", serif;
            font-size: large;
        }
        .auto-style3 {
            color: #FF3300;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            background-color: #CCFF99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Head Line 1</h1>
        <h2>Headline 2</h2>
        <h3>Headline 3</h3>
        <h4>Headline 4</h4>
        <h5>Headline 5</h5>
        <h6>Headline 6</h6>
        <p class="auto-style2">
            <strong>This is some text to <span class="auto-style3">apply</span> a style to</strong></p>
        <p>
            <a href="http://www.learnvisualstudio.net">Add a hyperlink</a></p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="www.google.com" Target="_blank">This is another hyperlink</asp:HyperLink>
        </p>
        <p>
            <img class="auto-style1" src="pomegranate.jpg" /></p>
        <table class="auto-style4">
            <tr>
                <td>Player</td>
                <td>Year</td>
                <td>Score</td>
            </tr>
            <tr>
                <td class="auto-style5">Sammy Sosa</td>
                <td class="auto-style5">2005</td>
                <td class="auto-style5">100</td>
            </tr>
            <tr>
                <td>Mark MacGuire</td>
                <td>2006</td>
                <td>102</td>
            </tr>
        </table>
    
    </div>
    </form>
    <ol>
        <li>First item</li>
        <li>Second item</li>
        <li>Third item</li>
    </ol>
    <ul>
        <li class="auto-style6">An idea</li>
        <li class="auto-style6">An equally good idea</li>
        <li class="auto-style6">Yet another idea to consider</li>
    </ul>
    <p>
        &nbsp;</p>
</body>
</html>
