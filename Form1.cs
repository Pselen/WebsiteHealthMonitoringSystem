using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Wehemo.Business;

namespace WehemoCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void StartTest()
        {
            while (true)
            {
                using (WEHEMODataContext dc = new WEHEMODataContext()) //Database connection.
                {
                    var tests = dc.Tests.Select(c => new { c.ID, c.URL }).ToList();

                    foreach (var test in tests)
                    {
                        var code = -1; //Initial value.

                        try
                        {
                            var request = (HttpWebRequest)WebRequest.Create(test.URL); //Send request to open the website .

                            using (var response = (HttpWebResponse)request.GetResponse()) //Get response from this website. 
                            {
                                code = (int)response.StatusCode;
                            }
                        }
                        catch (WebException ex)
                        {
                            if (ex.Response == null)//If there is no such kind of a website.
                            {
                                code = (int)ex.Status; //Get the exit code.
                            }
                            else
                            {
                                using (var response = (HttpWebResponse)ex.Response) //If there is a website.
                                {
                                    code = (int)response.StatusCode; //Get the response code.
                                }
                            }
                        }
                        WehemoBusiness.TestLog(test.ID, code); //Perform this test each 1000 milisec.
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)  //istek oluşturuyor. sonra da cevabı alıyor.
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTest();
        }

    }
}
