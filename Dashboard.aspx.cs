using System;
using System.Linq;
using Wehemo.Business;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    DTO_TEST[] Testlist(Guid customerId) //DTO stands for Data Transfer Object.
    {
        using (var dc = new WEHEMODataContext())    //Database connection.
        {
            return dc.Tests.Where(c => c.CustomerID == customerId).Select(c => new DTO_TEST
            {
                Name = c.Name,
                URL = c.URL,
                ID = c.ID
            }).OrderBy(c => c.Name).ToArray();
        }
    }
    public class DTO_TEST
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public Guid ID { get; set; }
    }

    protected void session(EventArgs e)
    {
        var obj = Session["customerID"];
        if (obj == null)
        {
            Response.Redirect("LoginForm.aspx");
        }
        else
        {
            var customerId = (Guid)obj;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*Log out*/
    }
}