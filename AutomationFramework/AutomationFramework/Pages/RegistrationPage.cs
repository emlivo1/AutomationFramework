using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using AutomationFramework.Data;
using System.Collections.Generic;
using AutomationFramework.Helpers;

namespace AutomationFramework.Pages
{
    public class RegistrationPage : Navigator
    {
        #region Elements
        [FindsBy(How.XPath, "//*[@title='Log in to your customer account']")]
        private IWebElement _signInButton;
        [FindsBy(How.Id, "email_create")]
        private IWebElement _emailField;
        [FindsBy(How.XPath, "//*[@class='icon-user left']")]
        private IWebElement _createAccountButton;
        [FindsBy(How.Id, "id_gender1")]
        private IWebElement _genderMr;
        [FindsBy(How.XPath, "//*[@id='id_gender2']")]
        private IWebElement _genderMrs;
        [FindsBy(How.Id, "customer_firstname")]
        private IWebElement _customerFirstName;
        [FindsBy(How.Id, "customer_lastname")]
        private IWebElement _customerLastName;
        [FindsBy(How.Id, "passwd")]
        private IWebElement _password;
        [FindsBy(How.Id, "days")]
        private IWebElement _days;
        [FindsBy(How.Id, "months")]
        private IWebElement _months;
        [FindsBy(How.Id, "years")]
        private IWebElement _year;
        [FindsBy(How.Id, "firstname")]
        private IWebElement _firstName;
        [FindsBy(How.Id, "lastname")]
        private IWebElement _lastName;
        [FindsBy(How.Id, "company")]
        private IWebElement _company;
        [FindsBy(How.Id, "address1")]
        private IWebElement _address1;
        [FindsBy(How.Id, "city")]
        private IWebElement _city;
        [FindsBy(How.Id, "id_state")]
        private IWebElement _state;
        [FindsBy(How.Id, "postcode")]
        private IWebElement _postcode;
        [FindsBy(How.Id, "country")]
        private IWebElement _country;
        [FindsBy(How.Id, "phone_mobile")]
        private IWebElement _phoneNumber;
        [FindsBy(How.Id, "alias")]
        private IWebElement _addressAlias;
        [FindsBy(How.Id, "submitAccount")]
        private IWebElement _submitButton;
        #endregion
        #region Public methods
        public MyAccountPage Register(Dictionary<string, string> database)
        {
            LogHelper.Write("Filling out Personal information");
            Wait();
            FillOutPersonalInfo(database);
            Wait();
            LogHelper.Write("Selecting dropdown option");
            SelectDropdown(database);
            Wait();
            LogHelper.Write("Filling out Your Address section");
            FillOutYourAddress(database);
            Wait();
            LogHelper.Write("Clicking on the submit button");
            _submitButton.Click();
            return MyAccountPage;

        }
        #endregion
        #region Private methods
        private RegistrationPage FillOutPersonalInfo(Dictionary<string, string> database)
        {
            Wait(45);
            _genderMrs.Click();
            _customerFirstName.Click();
            _customerFirstName.SendKeys(database["firstName"]);
            _customerLastName.Click();
            _customerLastName.SendKeys(database["lastName"]);
            _password.Click();
            _password.SendKeys(database["pass"]);
            return RegistrationPage;
        }
        //select date of birth
        private RegistrationPage SelectDropdown(Dictionary<string, string>database)
        {
            _days.Click();
            SelectElement _dropDownDays = new SelectElement(_days);
            _dropDownDays.SelectByValue(database["days"]);
            _months.Click();
            SelectElement _dropDownMonths = new SelectElement(_months);
            _dropDownMonths.SelectByValue(database["months"]);
            _year.Click();
            SelectElement _dropDownYear = new SelectElement(_year);
            _dropDownYear.SelectByValue(database["years"]);
            _state.Click();
            SelectElement _dropDownState = new SelectElement(_state);
            _dropDownState.SelectByValue(database["state"]);

            return RegistrationPage;
        }

        private RegistrationPage FillOutYourAddress(Dictionary<string, string> database)
        {
   
            _company.Click();
            _company.SendKeys(database["company"]);

            _address1.Click();
            _address1.SendKeys(database["address1"]);

            _city.Click();
            _city.SendKeys(database["city"]);

            _postcode.Click();
            _postcode.SendKeys(database["postcode"]);
            _phoneNumber.Click();
            _phoneNumber.SendKeys(database["phone_number"]);
            _addressAlias.Click();
            _addressAlias.SendKeys(database["address_alias"]);

            return RegistrationPage;

            
        }
        #endregion
    }
}