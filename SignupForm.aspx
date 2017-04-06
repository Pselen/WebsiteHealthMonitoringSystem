<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignupForm.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Signup.css" rel="stylesheet" />
</head>

<body>
    <form id="form1" runat="server">
        <h1 id="header">Sign up</h1>
            <br />
        <div class="boxes" style="margin-left: 0x">
            <asp:Label ID="Label2" runat="server" Text="Name*"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextNameBox" runat="server" MaxLength =" 100" ></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server" Text="E-mail*"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextEmailBox" runat="server" EnableTheming="True" MaxLength="100" ValidateRequestMode="Enabled" ></asp:TextBox><br /><br />
            <asp:Label ID="Label4" runat="server" Text="Password*"></asp:Label>&nbsp;
            <asp:TextBox ID="TextPasswordBox" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox><br /><br />
        </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style= Text="Sign Up" Width="72px" /><br />
        <div>    
            <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ControlToValidate ="TextNameBox" ErrorMessage="Please enter a name." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator><br />        
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate ="TextEmailBox" ErrorMessage="Please enter an E-mail address." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator><br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextEmailBox" ErrorMessage="Please enter a valid E-mail address." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate ="TextPasswordBox" ErrorMessage="Please enter a password." SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </form>
</body>
</html>