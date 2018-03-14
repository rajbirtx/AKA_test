using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AKANewMedia.GenericMethods;
using TechTalk.SpecFlow;
using AKANewMedia.ElementRepo;
using OpenQA.Selenium;
//using AKANewMedia.ExcelReader;

namespace AKANewMedia.StepDefinitions
{
    [Binding]
     class GeneralDonation : ElementRepos
    {
        
        [Given(@"Selecting General Donate Section")]
        public void GivenSelectingGeneralDonateSection()
        {
            //ScenarioContext.Current.Pending();
            GeneralMethods.ClickOnElementWhenElementFound(DonateButton);
            GeneralMethods.ClickOnElementWhenElementFound(GeneralDonationButton);
            GeneralMethods.ClickOnElementWhenElementFound(Submit);

        }

        [Given(@"I have entered all the mandatory fileds into the General Donation scenario")]
        public void GivenIHaveEnteredAllTheMandatoryFiledsIntoTheGeneralDonationScenario()
        {            
            GeneralMethods.ClickOnElementWhenElementFound(OneTimeDonation);
            System.Threading.Thread.Sleep(2000);
            GeneralMethods.ClickOnElementWhenElementFound(DonationAmount);
            System.Threading.Thread.Sleep(1000);
            GeneralMethods.ClickOnElementWhenElementFound(CoverAdminFee);
            
            GeneralMethods.SendKeysForWebElement(FundAllocationType, "Sample Fund 2");
            GeneralMethods.SendKeysForElement(FirstName, "Test");
            GeneralMethods.SendKeysForElement(LastName, "Test");
            System.Threading.Thread.Sleep(1000);
            GeneralMethods.selectValueFromDropdown(EmailDropdownType, "Business");
            System.Threading.Thread.Sleep(1000);
            GeneralMethods.SendKeysForElement(EmailAddressText, "Test@Test.com");
            GeneralMethods.SendKeysForElement(ConfirmEmailAddressText, "Test@Test.com");
            GeneralMethods.SendKeysForElement(CompanyName, "Demo");
            GeneralMethods.selectValueFromDropdown(AddressDropdownType,"Business");
            GeneralMethods.selectValueFromDropdown(CountryDropdown, "Canada");
            GeneralMethods.SendKeysForElement(AddressLine1, "Address Line 1");
            GeneralMethods.SendKeysForElement(AddressLine2, "Address Line 2");
            GeneralMethods.SendKeysForElement(City, "Demo");
            GeneralMethods.selectValueFromDropdown(StateDropdown, "Ontario");
            GeneralMethods.SendKeysForElement(ZipCode, "L7J 0A5");
            GeneralMethods.selectValueFromDropdown(PhoneDropdown, "Mobile");
            GeneralMethods.SendKeysForElement(PhoneNumberText, "9999988888");
            GeneralMethods.SendKeysForElement(PhoneExtension, "+91");
            GeneralMethods.selectValueFromDropdown(GenderDropdown, "Male");
            GeneralMethods.selectValueFromDropdown(DayDropdownType, "5");
            GeneralMethods.selectValueFromDropdown(MonthDropdownType, "June");
            GeneralMethods.selectValueFromDropdown(YearDropdownType, "2018");
            GeneralMethods.selectValueFromDropdown(LanguageDropdownType, "English");
            
            GeneralMethods.ClickOnElementWhenElementFound(ReceiveCommunicationCheckbox);
            System.Threading.Thread.Sleep(1000);
            GeneralMethods.ClickOnElementWhenElementFound(MailingCheckbox);
            GeneralMethods.ClickOnElementWhenElementFound(CreditCardRadioButton);
            GeneralMethods.SendKeysForElement(CardNumberText,"4242424242424242");
            GeneralMethods.SendKeysForElement(CardHolderName,"Test");
            GeneralMethods.selectValueFromDropdown(ExpirationMonthDropdownType,"10");
            GeneralMethods.selectValueFromDropdown(ExpirationYearDropdownType, "2022");
            GeneralMethods.ClickOnElementWhenElementFound(ContinueButton);
            System.Threading.Thread.Sleep(2000);
           
           

            //report.ReportPass(ScenarioName);

        }

        [When(@"I successfully saved all the pages and clicked on Proces payment")]
        public void WhenISuccessfullySavedAllThePagesAndClickedOnProcesPayment()
        {          
            System.Threading.Thread.Sleep(2000);
            int rows = GeneralMethods.driver.FindElements(By.XPath("//div[@id='ctl00_content_ucDonationReview_divAmount']/table/tbody/tr[3]/td/table/tbody/tr")).Count;
            for (int i = 1; i <= rows; i++)
            {
                string data = GeneralMethods.driver.FindElement(By.XPath("//div[@id='ctl00_content_ucDonationReview_divAmount']/table/tbody/tr[3]/td/table/tbody/tr[" + i + "]/td[2]")).Text;
                Console.WriteLine(data);
            }
            System.Threading.Thread.Sleep(5000);
            int rows1 = GeneralMethods.driver.FindElements(By.XPath("//div[@id='ctl00_content_ucDonationReview_divProfile']/table/tbody/tr[2]/td/table/tbody/tr")).Count;
            for (int j = 1; j <= rows1; j++)
            {
                string data1 = GeneralMethods.driver.FindElement(By.XPath("//div[@id='ctl00_content_ucDonationReview_divProfile']/table/tbody/tr[2]/td/table/tbody/tr[" + j + "]/td[2]")).Text;
                Console.WriteLine(data1);
            }
            System.Threading.Thread.Sleep(5000);
            int rows2 = GeneralMethods.driver.FindElements(By.XPath("//div[@id='ctl00_content_ucDonationReview_ucPayment_divPaymentCardDetails']/table/tbody/tr")).Count;
            for (int k = 1; k <= rows2; k++)
            {
                string data2 = GeneralMethods.driver.FindElement(By.XPath("//div[@id='ctl00_content_ucDonationReview_ucPayment_divPaymentCardDetails']/table/tbody/tr[" + k + "]/td[2]")).Text;
                Console.WriteLine(data2);
            }
            System.Threading.Thread.Sleep(2000);
            GeneralMethods.ClickOnElementWhenElementFound(EditButton);
            System.Threading.Thread.Sleep(1000);
            GeneralMethods.SendKeysForWebElement(City, "Editted Demo");
            GeneralMethods.ClickOnElementWhenElementFound(CreditCardRadioButton);
            GeneralMethods.SendKeysForElement(CardNumberText, "4242424242424242");
            GeneralMethods.SendKeysForElement(CardHolderName, "Test");
            GeneralMethods.selectValueFromDropdown(ExpirationMonthDropdownType, "10");
            GeneralMethods.selectValueFromDropdown(ExpirationYearDropdownType, "2022");
            GeneralMethods.ClickOnElementWhenElementFound(ContinueButton);


        }

        [Then(@"the Transaction code is displayed successfully")]
        public void ThenTheTransactionCodeIsDisplayedSuccessfully()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
