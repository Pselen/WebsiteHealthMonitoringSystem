<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="Dashboard.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="header">Homepage</h1>
        <div class="right">
            <asp:LoginName ID="LoginName1" runat="server" />
            &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Log Out" OnClick="Button1_Click" /><br />
            <br />
        </div>
        </br></br>
        </br>
        <nav class="navigation">
            <ul class="mainmenu">
                <li><a href="Dashboard.asp">Home</a></li>
                <li><a href="">Tests</a>
                    <ul class="submenu">
                        <li><a href="TestReport.aspx">List Tests</a></li>
                        <li><a href="TestForm.aspx">Add new test</a></li>
                        <li><a href="">Test update</a></li>
                        <li><a href="">Test delete</a></li>
                    </ul>
                </li>
                <li><a href="#Settings">Settings</a></li>
            </ul>
        </nav>

    </form>
</body>
</html>
