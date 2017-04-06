using System;
using Wehemo.Business;

public partial class TestForm : System.Web.UI.Page
{
    protected void Button1_Click(object sender, EventArgs e)
    {
        Guid newGuid = new Guid();
        newGuid = (Guid)Session["customerId"];
        var url = txtbxURL.Text;
        var urlName = txtbxURLName.Text;

        WehemoBusiness.TestAdd(newGuid, urlName, url);

    }
    protected void txtbxURLName_TextChanged(object sender, EventArgs e)
    {

    }
}


