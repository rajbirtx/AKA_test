using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKANewMedia.GenericMethods;
using NUnit.Framework;
using RelevantCodes.ExtentReports;

namespace AKANewMedia.Report
{
    class BasicReport
    {
        public ExtentReports extent;
        public ExtentTest test;
        public TestContext testcontext = null;
        public string date = DateTime.Now.ToString("yyyyMMddTHHmmss");

        string BrowserName = ConfigurationManager.AppSettings["BrowserName"];
        string screenShotPath;
        public void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string ts = date;
            string reportPath = projectPath + "Results\\Report.html";

            extent = new ExtentReports(reportPath, false, DisplayOrder.NewestFirst);
            extent.AddSystemInfo("Host Name", "AKANewMedia");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User Name", "Aman");
            extent.AddSystemInfo("Browser Name", BrowserName);
            extent.LoadConfig(projectPath + "extent-config.xml");
        }

        public void ReportPass(string methodname)
        {
            try
            {
                StartReport();

                test = extent.StartTest(methodname);
                //test.AssignCategory(category);
                Assert.IsTrue(true);
                test.Log(LogStatus.Pass, methodname + " PASSED");
                string screenshotname = DateTime.Now.ToString("yyyy-MM-dd-THHmmss");
                screenShotPath = GeneralMethods.ScreenShotCapture(screenshotname);
                test.Log(LogStatus.Pass, test.AddScreenCapture(screenShotPath));
                //GetResult();
                EndReport();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void ReportFail(string methodname)
        {
            try
            {
                StartReport();
                test = extent.StartTest(methodname);
                //test.AssignCategory(category);
                Assert.IsTrue(true);
                test.Log(LogStatus.Fail, methodname + " FAILED");
                string screenshotname = DateTime.Now.ToString("yyyy-MM-dd-THHmmss");
                screenShotPath = GeneralMethods.ScreenShotCapture(screenshotname);
                test.Log(LogStatus.Fail, test.AddScreenCapture(screenShotPath));
                //GetResult();
                EndReport();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
       
       

        public void EndReport()
        {
            extent.Flush();       
        }

    
    }
}
