using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using AKANewMedia.GenericMethods;

namespace AKANewMedia.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            string BrowserName = ConfigurationManager.AppSettings["BrowserName"];
            string URL = ConfigurationManager.AppSettings["URL"];
            Console.WriteLine(BrowserName);
            Console.WriteLine(URL);
            if (BrowserName.ToLower() == "chrome")
            {
                GeneralMethods.driver = new ChromeDriver(@"C:\Users\Rajbir.Kaur\source\repos\automation\AKANewMedia\Drivers");
                GeneralMethods.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
                GeneralMethods.driver.Navigate().GoToUrl(URL);
                GeneralMethods.driver.Manage().Window.Maximize();
            }
            else if (BrowserName.ToLower() == "ie")
            {
                var options = new InternetExplorerOptions();
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                GeneralMethods.driver = new InternetExplorerDriver(options);
                GeneralMethods.driver = new InternetExplorerDriver(@"C:\Users\Rajbir.Kaur\source\repos\automation\AKANewMedia\Drivers");
                GeneralMethods.driver.Navigate().GoToUrl(URL);
                System.Threading.Thread.Sleep(100);
                GeneralMethods.driver.Manage().Window.Maximize();
            }
            else if (BrowserName.ToLower() == "firefox")
            {

                FirefoxProfileManager Manager = new FirefoxProfileManager();

                FirefoxProfile profile = Manager.GetProfile("Default");

                FirefoxDriverService Service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Rajbir.Kaur\source\repos\automation\AKANewMedia\Drivers");

                FirefoxOptions options = new FirefoxOptions();
                options.Profile = profile;

                IWebDriver objFirefox = new FirefoxDriver(Service, options, TimeSpan.FromSeconds(60));

                objFirefox.Navigate().GoToUrl(URL);


            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            GeneralMethods.driver.Quit();
        }
    }
}
