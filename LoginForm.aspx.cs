using System;
using Wehemo.Business;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    //log in
    protected void Button1_Click1(object sender, EventArgs e)
    {

        var password = CustomerPasswordBox.Text;
        var eMail = CustomerEmailBox.Text;
        var customerId = WehemoBusiness.CustomerLogin(eMail, password);
        if (customerId == null)
        {
            Label1.Text = "Wrong password or username.";
        }
        else
        {
            Session["customerId"] = customerId;
            Response.Redirect("Dashboard.aspx");
        }
    }

    protected void CustomerPasswordBox_TextChanged(object sender, EventArgs e)
    {

    }
}