<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestForm.aspx.cs" Inherits="TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="TestForm.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <h1 id="header">Add New Test</h1>
    <div  class="boxes" style="margin-left: 0x"><br />
        <asp:Label ID="Label1" runat="server" Text="URL Name"></asp:Label>&nbsp;
        <asp:TextBox ID="txtbxURLName" runat="server" OnTextChanged="txtbxURLName_TextChanged"></asp:TextBox><br/><br/>
        <asp:Label ID="Label2" runat="server" Text="URL*"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtbxURL" runat="server"></asp:TextBox>
    </div>
        <div> <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />     
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtbxURL" ErrorMessage="Please enter a URL." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </form>
</body>
</html>
