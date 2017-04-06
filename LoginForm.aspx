<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginForm.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<script runat="server">
    protected void CustomerPasswordBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CustomerEmailBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log in</title>
    <link href="Login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <h1 id="header">Sign in</h1>
            <br />
            <div class="boxes" style="margin-left: 0x">
                <asp:Label ID="Label2" runat="server" Text="E-mail" ></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox  ID="CustomerEmailBox" runat="server" TextMode="Email"></asp:TextBox><br /><br />
                <asp:Label ID="Label3" runat="server" Text="     Password"></asp:Label>&nbsp;
                <asp:TextBox ID="CustomerPasswordBox" runat="server" TextMode="Password" OnTextChanged="CustomerPasswordBox_TextChanged"></asp:TextBox><br /><br />
            </div>
        <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click1" Height="28px" Width="74px" />
                 <div style="margin-left: 0x">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="CustomerEmailBox" 
                    ErrorMessage="Please enter an E-mail address."></asp:RequiredFieldValidator><br />
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="CustomerPasswordBox" 
                    ErrorMessage="Please enter the password."></asp:RequiredFieldValidator>  
                <asp:RegularExpressionValidator  ID="RegularExpressionValidator1" runat="server" ControlToValidate="CustomerEmailBox" 
                    ErrorMessage="" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                
               
                </div>
                
    </form>
</body>
</html>
