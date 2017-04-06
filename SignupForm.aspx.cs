using System;
using Wehemo.Business;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var name = TextNameBox.Text;
        var email = TextEmailBox.Text;
        var password = TextPasswordBox.Text;
        WehemoBusiness.CustomerAdd(name, email, password);
        Response.Redirect("Dashboard.aspx");
    }

    protected void TestNameBox_TextChanged(object sender, EventArgs e)
    {

    }
}