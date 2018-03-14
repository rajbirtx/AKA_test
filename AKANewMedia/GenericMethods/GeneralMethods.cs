using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AKANewMedia.Report;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AKANewMedia.GenericMethods
{
    class GeneralMethods
    {
        public static IWebDriver driver;
        BasicReport report = new BasicReport();

        public static void maximiseBrowser()
        {
            driver.Manage().Window.Maximize();

        }
        public static void explicitWait(By aByElement, int aWaitTimeInSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(aWaitTimeInSec));
                wait.Until(ExpectedConditions.ElementIsVisible(aByElement));

            }

            catch (TimeoutException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static bool WaitUntillElementIsVisible(By aByeValue, int timeOut)
        {

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(aWaitTimeInSec));
            //wait.Until(ExpectedConditions.ElementIsVisible(aByElement));
            int iTimer = 0;
            while (iTimer <= timeOut)
            {
                bool status = IsElementVisible(aByeValue);
                if (status)
                    return true;
            }
            return false;
        }
        public static void browserBackNavigation()
        {
            driver.Navigate().Back();

        }

        public static void browserForwardNavigation()
        {
            driver.Navigate().Forward();

        }

        public static String getAttributeOfWebelementByLocator(By aByValue, String aAttribute)
        {
            explicitWait(aByValue, 300);
            IWebElement element = driver.FindElement(aByValue);
            return element.GetAttribute(aAttribute);
        }


        public static IWebElement getWebElementByLocator(By aBy)
        {
            explicitWait(aBy, 300);
            IWebElement webElement = driver.FindElement(aBy);
            return webElement;
        }

        public static string getTextOfWebElementByLocator(By aWebElementID)
        {
            return getWebElementByLocator(aWebElementID).Text;
        }

        public static void ClickOnElementWhenElementFound(By aByValue)
        {
            //System.Threading.Thread.Sleep(2000);
            explicitWait(aByValue, 300);
            IWebElement webElement = getWebElementByLocator(aByValue);
            webElement.Click();
        }
        public static void SendKeysForElement(By aByValue, String aTestData)
        {
            try
            {
                driver.FindElement(aByValue).SendKeys(aTestData);

            }
            catch (ElementNotVisibleException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void SendKeysForWebElement(By aByValue, String aTestData)
        {
            try
            {
                driver.FindElement(aByValue).Clear();
                driver.FindElement(aByValue).SendKeys(aTestData);

            }
            catch (ElementNotVisibleException e)
            {
                Console.WriteLine(e.ToString());
            }


        }
        public static bool IsElementVisible(By aByValue)
        {
            try
            {
                IWebElement element = driver.FindElement(aByValue);
                if (element.Displayed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool waitUntilElementNotVisible(By aByeValue, int timeOut)
        {

            int iTimer = 0;
            while (iTimer <= timeOut)
            {
                bool status = !(IsElementVisible(aByeValue));
                if (status)
                    return true;
            }
            return false;
        }
        public static bool IsElementPresent(By aByValue)
        {
            try
            {
                driver.FindElement(aByValue);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public static String selectValueFromDropdown(By aByValue,string value)
        {
            try
            {
                SelectElement oSelect = new SelectElement(driver.FindElement(aByValue));
                 oSelect.SelectByText(value);
                return value;                   
            }
            catch (NoSuchElementException)
            {
                return null ;
            }
        }

        public static string ScreenShotCapture(string screenShotName)
        {

            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string finalpth = projectPath + "Results\\" + screenShotName + ".jpeg";
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            //string finalpth = "E:\\git_project_new_09-05-2017\\new\\Test\\Anicitus-BRT\\Anicitus-BRT\\Results";
            screenshot.SaveAsFile(finalpth, ScreenshotImageFormat.Jpeg);
            return finalpth;
        }
    }
}
