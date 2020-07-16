

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationPracticeLibrary.Repository
{
    public class AuthenticationRepo
    {
        [FindsBy(How = How.Id, Using = "email_create")]
        protected IWebElement emailTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        protected IWebElement createAccountButton { get; set; }

        [FindsBy(How = How.Id, Using = "id_gender1")]
        protected IWebElement mrTitleCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "uniform-id_gender2")]
        protected IWebElement mrsTitleCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        protected IWebElement firstNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        protected IWebElement lastNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        protected IWebElement emailProfileTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        protected IWebElement passwordTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "days")]
        protected IWebElement daySelect { get; set; }

        [FindsBy(How = How.Id, Using = "months")]
        protected IWebElement monthSelect { get; set; }

        [FindsBy(How = How.Id, Using = "years")]
        protected IWebElement yearSelect { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        protected IWebElement addressFirstNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        protected IWebElement addressLastNameTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        protected IWebElement addressCompanyTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        protected IWebElement addressFirstAddressTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        protected IWebElement addressSecondAddressTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        protected IWebElement addressCityTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "id_state")]
        protected IWebElement addressStateSelect{ get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        protected IWebElement addressZipCodeTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
        protected IWebElement addressCountrySelect { get; set; }

        [FindsBy(How = How.Id, Using = "other")]
        protected IWebElement addressAdditionalInformationTextBox{ get; set; }

        [FindsBy(How = How.Id, Using = "phone")]
        protected IWebElement addressHomeNumberTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        protected IWebElement addressMobileNumberTextBox { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        protected IWebElement addressAliasTextBox{ get; set; }

        [FindsBy(How = How.Id, Using = "submitAccount")]
        protected IWebElement registerButton { get; set; }

    }
}
