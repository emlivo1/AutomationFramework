using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Pages;
using AutomationFramework.Utilities;
using AutomationFramework.Helpers;

namespace AutomationFramework.Pages
{
    public class SignInPage : Navigator
    {
        #region Elements
        [FindsBy(How.XPath, "//input[@id='email'] ")]
        private IWebElement EmailField;

        [FindsBy(How.XPath, "//input[@id='passwd'] ")]
        private IWebElement PasswordField;

        [FindsBy(How.XPath, "//button[@id='SubmitLogin']")]
        private IWebElement SignInButton;

        [FindsBy(How.Id, "email_create")]
        private IWebElement _emailField;

        [FindsBy(How.XPath, "//*[@class='icon-user left']")]
        private IWebElement _createAccountButton;



        #endregion


        #region Public methods
        public MyAccountPage LogIn(string newEmail, string newPass)
        {
            LogHelper.Write("Logging in");

            EmailField.Click();
            EmailField.SendKeys(newEmail);
            PasswordField.Click();
            PasswordField.SendKeys(newPass);
            SignInButton.Click();

            return MyAccountPage;
        }

        public RegistrationPage CreateAccount(string newEmail)
        {
            LogHelper.Write("Creating Account");
            _emailField.Click();
            _emailField.SendKeys(newEmail);
            _createAccountButton.Click();
            Wait();
            return RegistrationPage;
        }
        #endregion
    }
}
