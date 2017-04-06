using System;
using System.Linq;
using Wehemo.Business;

namespace WebSite2
{
    public partial class TestReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DTO_TEST_REPORT[] Test_Report(Guid testId)
        {
            using (var dc = new WEHEMODataContext())
            {
                return dc.TestResults.Where(c => c.TestID == testId).Select(c => new DTO_TEST_REPORT
                {
                    Code = c.StatusCode,
                    Description = c.StatusCodes.Descriptions,
                    Date = c.ResultDate
                }).OrderByDescending(c => c.Date).ToArray();
            }
        }
        public class DTO_TEST_REPORT
        {
            public int Code { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}