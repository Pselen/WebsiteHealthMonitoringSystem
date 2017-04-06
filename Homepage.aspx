<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
   <link href="Homepage.css" rel="stylesheet" />
    
</head>
<body >
    <!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<!-- Optional theme -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <form id="form1" runat="server">
        <div id="header">
        <h1 >Website Health Monitoring System</h1>
        </div>
        
            <div id="center">
                <!--buttons and explanation-->
                <p>This webpage aims to help you to check your website. In order to continue please <em>Log in</em> or <em>Sign up</em>!</p>
            </div>
                <div style ="text-align:center;">
                     <!--<input id="Button1" type="button" value="Log in" />-->
                     <!--<input id="Button2" type="button" value="Sign up" />-->
                    <asp:Button ID="Button1" runat="server" Text="Sign in" OnClientClick="window.open('LoginForm.aspx')" OnClick="Button1_Click1" style="height: 24px" /> &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Sign up" OnClientClick="window.open('SignupForm.aspx')" />
                </div>
                   <!-- <div id="footer">  
                    </div>-->
    </form>
</body>
</html>
