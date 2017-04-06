using System;
using System.Linq;

namespace Wehemo.Business
{
    /// <summary>
    /// Summary description for WehemoBusiness
    /// </summary>
     //log out metodu yaz.

    public class WehemoBusiness
    {

        public static void CustomerAdd(string name, string eMail, string password)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext()) // Database connection.
            {
                var item = new Customer(); //Create new item.
                item.ID = Guid.NewGuid(); //Guid method will randomly generate an alphanumerical ID:
                item.Name = name;
                item.Email = eMail;
                item.Password = password;
                item.CreatedDate = DateTime.Now;

                dc.Customers.InsertOnSubmit(item); //Submit changes to database.

                dc.SubmitChanges();
            }
        }

        public static void CustomerUpdate(Guid customerId, string name, string eMail, string password)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext()) // Database connection.
            {
                var item = dc.Customers.First(c => c.ID == customerId); //Select first customer whose ID equal to given ID.
                item.Name = name;
                item.Email = eMail;
                item.Password = password;

                dc.SubmitChanges(); //Submit changes to database.
            }
        }

        public static Guid? CustomerLogin(string eMail, string password)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext()) // Database connection.
            {
                //Select from database whose email address and password macthes with the given information.
                return dc.Customers.Where(c => c.Email == eMail && c.Password == password).Select(c => (Guid?)c.ID).FirstOrDefault();
            }

        }

        public static void TestAdd(Guid customerId, string name, string url)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext()) // Database connection.
            {
                var test = new Test();

                test.ID = Guid.NewGuid();
                test.CustomerID = customerId;
                test.Name = name;
                test.URL = url;
                test.CreatedDate = DateTime.Now;

                dc.Tests.InsertOnSubmit(test);
                dc.SubmitChanges();
            }
        }
        public static void TestUpdate(Guid testId, string name, string url)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext()) // Database connection.
            {
                var item = dc.Tests.Single(c => c.ID == testId);

                item.Name = name;
                item.URL = url;

                dc.SubmitChanges();
            }
        }

        public static void TestDelete(Guid testId)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext()) // Database connection.
            {
                var item = dc.Tests.First(c => c.ID == testId);
                dc.Tests.DeleteOnSubmit(item); //Submit changes to database.
                dc.SubmitChanges();
            }
        }

        public static void TestList(Guid customerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Test sonucu kaydediliyor
        /// </summary>
        public static void TestLog(Guid testId, int statusCode)
        {
            using (WEHEMODataContext dc = new WEHEMODataContext())
            {
                var item = new TestResult();

                item.TestID = testId;
                item.ResultID = Guid.NewGuid();
                if (statusCode == -1)
                {
                    statusCode = 404;
                }
                item.StatusCode = statusCode;
                item.ResultDate = DateTime.Now;


                dc.TestResults.InsertOnSubmit(item);

                dc.SubmitChanges();

            }
        }



        //public static void TestLog(Guid testId, int statusCode)
        //{
        //    using (WEHEMODataContext dc = new WEHEMODataContext())
        //    {
        //        var item = new TestResult();

        //        item.TestID = testId;
        //        item.ResultID = Guid.NewGuid();
        //        item.StatusCode = statusCode;
        //        item.ResultDate = DateTime.Now;


        //        dc.TestResults.InsertOnSubmit(item);
        //        dc.SubmitChanges();
        //    }
        //}


        //DTO_Test[] TestList(Guid customerId)
        //{
        //    using (WEHEMODataContext dc = new WEHEMODataContext())
        //    {
        //        return dc.Tests.Where(c => c.CustomerID == customerId).Select(c => new DTO_Test
        //        {
        //            Name = c.Name,
        //            ID = Guid.NewGuid(ID),
        //            URL=c.URL,
        //        }).OrderBy(c => c.Name);
        //    }
        //    //Data Source = WehemoBusiness.TestList(CustomerId).DataBind();
        //}


        //DTO_TestReport[] TestReport(Guid TestId)
        //{
        //    dc.TestResults.Where(c => c.TestId == testId).Select(c => new DTO_TestResult
        //    {
        //        Status = c.StatusCode,
        //        Description = c.Status.Description,
        //        Date = c.CreatedDate
        //    }).OrderByDescending(c => c.Date).ToArray();
        //}


    }
}