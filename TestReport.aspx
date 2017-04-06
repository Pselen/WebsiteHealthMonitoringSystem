<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TestReport.aspx.cs" Inherits="WebSite2.TestReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="StatusCode" HeaderText="StatusCode" SortExpression="StatusCode" />
                <asp:BoundField DataField="ResultDate" HeaderText="ResultDate" SortExpression="ResultDate" />
                <asp:BoundField DataField="TestID" HeaderText="TestID" SortExpression="TestID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WeHeMoConnectionString %>" SelectCommand="SELECT [StatusCode], [ResultDate], [TestID] FROM [TestResult] ORDER BY [ResultDate] DESC"></asp:SqlDataSource>
    </form>
</body>
</html>
