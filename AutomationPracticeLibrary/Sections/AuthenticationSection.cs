using AutomationPracticeLibrary.Repository;
using AutomationPracticeLibrary.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeLibrary.Sections
{
    public class AuthenticationSection: AuthenticationRepo
    {
        public AuthenticationSection()
        {
            PageFactory.InitElements(Driver.Instance, this);
        }

        public void CreateAccount(string email)
        {
            var random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var randomEmailSufix = new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            email = $"example-{randomEmailSufix}@email.com";
            PageUtils.enter(emailTextBox, email);
            PageUtils.click(createAccountButton);
        }

        public AuthenticationSection SelectTitle(string title)
        {
            switch(title)
            {
                case "mr":
                    PageUtils.click(mrTitleCheckBox);
                    break;
                case "mrs":
                    PageUtils.click(mrsTitleCheckBox);
                    break;
            }

            return this;
        }

        public AuthenticationSection EnterFirstName(string firstName)
        {
            PageUtils.enter(firstNameTextBox, firstName);
            return this;
        }

        public AuthenticationSection EnterLastName(string lastName)
        {
            PageUtils.enter(lastNameTextBox, lastName);
            return this;
        }

        public AuthenticationSection EnterEmail(string email)
        {
            PageUtils.enter(emailTextBox, email);
            return this;
        }

        public AuthenticationSection EnterPassword(string password)
        {
            PageUtils.enter(passwordTextBox, password);
            return this;
        }

        public AuthenticationSection SelectDateOfBirth(string day, string month, string year)
        {
            PageUtils.selectByValue(daySelect, day);
            PageUtils.selectByValue(monthSelect, month);
            PageUtils.selectByValue(yearSelect, year);
            return this;
        }

        public AuthenticationSection EnterAddressFirstName(string firstName )
        {
            PageUtils.enter(addressFirstNameTextBox, firstName);
            return this;
        }

        public AuthenticationSection EnterAddressLastName(string lastName)
        {
            PageUtils.enter(addressLastNameTextBox, lastName);
            return this;
        }

        public AuthenticationSection EnterAddressCompany(string company)
        {
            PageUtils.enter(addressCompanyTextBox, company);
            return this;
        }

        public AuthenticationSection EnterAddressFirstLine(string addresLine1)
        {
            PageUtils.enter(addressFirstAddressTextBox, addresLine1);
            return this;
        }

        public AuthenticationSection EnterAddressSecondLine(string addresLine2)
        {
            PageUtils.enter(addressSecondAddressTextBox, addresLine2);
            return this;
        }

        public AuthenticationSection EnterAddressCity(string city)
        {
            PageUtils.enter(addressCityTextBox, city);
            return this;
        }

        public AuthenticationSection SelectState(string state)
        {
            PageUtils.selectByText(addressStateSelect, state);
            return this;
        }

        public AuthenticationSection EnterZipCode(string zip)
        {
            PageUtils.enter(addressZipCodeTextBox, zip);
            return this;
        }

        public AuthenticationSection SelectCountry(string country)
        {
            PageUtils.selectByText(addressCountrySelect, country);
            return this;
        }

        public AuthenticationSection ProvideAdditionalInformation(string info)
        {
            PageUtils.enter(addressAdditionalInformationTextBox, info);
            return this;
        }

        public AuthenticationSection EnterHomePhone(string homePhone)
        {
            PageUtils.enter(addressHomeNumberTextBox, homePhone);
            return this;
        }

        public AuthenticationSection EnterMobilePhone(string mobile)
        {
            PageUtils.enter(addressMobileNumberTextBox, mobile);
            return this;
        }

        public AuthenticationSection AssignAlias(string alias)
        {
            PageUtils.enter(addressAliasTextBox, alias);
            return this;
        }

        public void Submit()
        {
            PageUtils.click(registerButton);
        }

        
    }
}
