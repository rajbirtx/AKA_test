using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using AKANewMedia.GenericMethods;
using AKANewMedia.Report;

namespace AKANewMedia.ElementRepo
{
    class ElementRepos 
    {
        public string ScenarioName = "";
        public BasicReport report = new BasicReport();

        // Homepage Elements 
        public static By DonateButton = By.XPath("//a[contains(@href,'/Donation/Event/DonationType')]");

        // Method of Payment Elements
        public static By GeneralDonationButton = By.Id("ctl00_content_ucDonationType_rbGeneral");
        public static By InHonourDonationButton = By.Id("ctl00_content_ucDonationType_rbInHonour");
        public static By InMemoryDonationButton = By.Id("ctl00_content_ucDonationType_rbInMemory");
        public static By Submit = By.ClassName("FormButton");

        // General Donation Page Elements
        public static By OneTimeDonation = By.Id("ctl00_contentAmount_ucAmount_btnOneTimeDonation");

        public static By RecurringDonation = By.Id("ctl00_contentAmount_ucAmount_btnRepeatingDonation");
        public static By DonationAmount = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_rdoDonationAmount']/label[5]");
        public static By CoverAdminFee = By.Id("ctl00_contentAmount_ucAmount_chkCoverAdminFee");
        public static By FundAllocationType = By.Id("ctl00_contentAmount_ucAmount_radComboBoxFundType_Input");
        public static By IndividualUserType = By.Id("ctl00_contentContactInformation_ucProfile_rdoIsCompany_0");
        public static By CompanyUserType = By.Id("ctl00_contentContactInformation_ucProfile_rdoIsCompany_1");
        public static By Title = By.Id("ctl00_contentContactInformation_ucProfile_ddlTitle");
        public static By FirstName = By.XPath("//*[contains(@id,'ctl00_contentContactInformation_ucProfile_txtFirstName')]");
        public static By LastName = By.XPath("//*[contains(@id,'ctl00_contentContactInformation_ucProfile_txtLastName')]");
        public static By EmailDropdownType = By.Id("ctl00_contentContactInformation_ucProfile_ddlEmailType");
        public static By EmailAddressText = By.Id("ctl00_contentContactInformation_ucProfile_txtEmailAddress");
        public static By ConfirmEmailAddressText = By.Id("ctl00_contentContactInformation_ucProfile_txtEmailAddressRepeat");
        public static By CompanyName = By.Id("ctl00_contentContactInformation_ucProfile_txtCompanyName");
        public static By AddressDropdownType = By.Id("ctl00_contentContactInformation_ucProfile_ddlAddressType");
        public static By CountryDropdown = By.Id("ctl00_contentContactInformation_ucProfile_ddlCountry");
        public static By AddressLine1 = By.Id("ctl00_contentContactInformation_ucProfile_txtAddressLine1");
        public static By AddressLine2 = By.Id("ctl00_contentContactInformation_ucProfile_txtAddressLine2");
        public static By City = By.Id("ctl00_contentContactInformation_ucProfile_txtCity");
        public static By StateDropdown = By.Id("ctl00_contentContactInformation_ucProfile_ddlProvince");
        public static By ZipCode = By.Id("ctl00_contentContactInformation_ucProfile_txtPostalCode");
        public static By PhoneDropdown = By.Id("ctl00_contentContactInformation_ucProfile_ddlPhoneType");
        public static By PhoneNumberText = By.Id("ctl00_contentContactInformation_ucProfile_txtPhone");
        public static By PhoneExtension = By.Id("ctl00_contentContactInformation_ucProfile_txtExt");
        public static By GenderDropdown = By.Id("ctl00_contentContactInformation_ucProfile_ddlGender");
        public static By DayDropdownType = By.Id("ctl00_contentContactInformation_ucProfile_dateOfBirth_lstDay");
        public static By MonthDropdownType = By.Id("ctl00_contentContactInformation_ucProfile_dateOfBirth_lstMonth");
        public static By YearDropdownType = By.Id("ctl00_contentContactInformation_ucProfile_dateOfBirth_lstYear");
        public static By LanguageDropdownType = By.Id("ctl00_contentContactInformation_ucProfile_ddlPrefCorrLanguage");
        public static By ReceiveCommunicationCheckbox = By.Id("ctl00_contentContactInformation_ucProfile_chkOptOut");
        public static By MailingCheckbox = By.Id("ctl00_contentContactInformation_ucProfile_chkOptOutToShare");
        public static By CreditCardRadioButton = By.Id("ctl00_contentPaymentInformation_ucPayment_rdoCreditCard");
        public static By PaypalRadioButton = By.Id("ctl00_contentPaymentInformation_ucPayment_rdoPayPal");
        public static By CardNumberText = By.XPath("//*[@id='txtCardNumber']");
        public static By CardHolderName = By.XPath("//*[@aria-labelledby='lblCardHolder' and contains(@id,'ctl00_contentPaymentInformation_ucPayment_ucCardPayment_txtCardHolder')]");
        public static By ExpirationMonthDropdownType = By.Id("ctl00_contentPaymentInformation_ucPayment_ucCardPayment_ddlExpirationMonth");
        public static By ExpirationYearDropdownType = By.Id("ctl00_contentPaymentInformation_ucPayment_ucCardPayment_ddlExpirationYear");
        public static By ContinueButton = By.Id("ctl00_contentSurvey_btnContinue");
        public static By PreviousButton = By.Id("ctl00_contentSurvey_btnPrevious");

        // Summary Page Elements
        public static By DonationDate = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucAmount_trFirstDonation']/td[2]");
        //public static By ValidateMonthlyDonation = By.XPath("//table/tbody/tr/td[2]/span[@id='ctl00_content_ucDonationReview_ucAmount_lblFirstDonation']");
        public static By ValidateAmount = By.XPath("//*[@id='ctl00_content_ucDonationReview_divAmount']/table/tbody/tr[3]/td/table/tbody/tr[2]/td[2]/span");
        public static By ValidateFund = By.XPath("//table/tbody/tr[3]/td[2]/span[@id='ctl00_content_ucDonationReview_ucAmount_lblFund']");
        public static By ValidateName = By.XPath("//table/tbody/tr/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblName']");
        public static By ValidateEmail = By.XPath("//table/tbody/tr[2]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblEmail']");
        public static By ValidateCompanyName = By.XPath("//table/tbody/tr[3]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblCompanyName']");
        public static By ValidateCountry = By.XPath("//table/tbody/tr[4]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblCountry']");
        public static By ValidateAddress = By.XPath("//table/tbody/tr[5]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblAddressLine1']");
        public static By ValidateCity = By.XPath("//table/tbody/tr[7]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblCity']");
        public static By ValidateProvince = By.XPath("//table/tbody/tr[8]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblProvince']");
        public static By ValidateZipCode = By.XPath("//table/tbody/tr[9]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblPostalCode']");
        public static By ValidatePhone = By.XPath("//table/tbody/tr[10]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblPhone']");
        public static By ValidateGender = By.XPath("//table/tbody/tr[11]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblGender']");
        public static By ValidateDOB = By.XPath("//table/tbody/tr[12]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblDOB']");
        public static By ValidateLanguage = By.XPath("//table/tbody/tr[13]/td[2]/span[@id='ctl00_content_ucDonationReview_ucProfile_lblCorrespondenceLanguage']");
        public static By ValidateCardType = By.XPath("//table[@id='tableCardInfo']/tbody/tr/td[2]/span");
        public static By ValidateCardNumber = By.XPath("//table[@id='tableCardInfo']/tbody/tr[2]/td[2]/span");
        public static By ValidateCardHolderName = By.XPath("//table[@id='tableCardInfo']/tbody/tr[3]/td[2]/span");
        public static By ValidateExpiryDate = By.XPath("//table[@id='tableCardInfo']/tbody/tr[4]/td[2]");

        public static By EditButton = By.XPath("//input[@id='ctl00_content_ucDonationReview_ucPayment_btnEdit']");
        public static By ProcessPaymentNow = By.XPath("//input[@id='ctl00_content_ucDonationReview_btnContinue']");
        
    }
}
