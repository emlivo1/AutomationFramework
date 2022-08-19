using AutomationFramework.Helpers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class CheckoutPage : Navigator
    {
        #region Elements
        [FindsBy(How.XPath, "//a[@title='Proceed to checkout']//span[text()='Proceed to checkout'] ")]
        private IWebElement ProceedSummary;

       

        [FindsBy(How.XPath, "//input[@id='email_create'] ")]
        private IWebElement EmailCreateField;

        [FindsBy(How.XPath, "//button[@id='SubmitCreate']")]
        private IWebElement CreateAccountButton;

        [FindsBy(How.XPath, "//button[@id='SubmitLogin']")]
        private IWebElement SignInButton;

        [FindsBy(How.XPath, "//button[@name='processAddress']")]
        private IWebElement ProceedAddress;

        [FindsBy(How.XPath, "//input[@type='checkbox']")]
        private IWebElement TOSCheckbox;

        [FindsBy(How.XPath, "//button[@name='processCarrier']")]
        private IWebElement ProceedShipping;

        [FindsBy(How.XPath, "//a[@class='bankwire']")]
        private IWebElement Bankwire;

        [FindsBy(How.XPath, "//a[@class='cheque']")]
        private IWebElement Cheque;

        [FindsBy(How.XPath, "//button//span[text()='I confirm my order']")]
        private IWebElement ConfirmationButton;

        [FindsBy(How.XPath, "//strong[text()='Your order on My Store is complete.']")]
        private IWebElement OrderConfirmationText;

        [FindsBy(How.XPath, "//ul/li[@class='step_current  first']/span")]
        private IWebElement SummaryConfirmation;

        [FindsBy(How.XPath, "//ul/li[@class='step_current third']/span")]
        private IWebElement AddressConfirmation;

        [FindsBy(How.XPath, "//ul/li[@class='step_current fourth']/span")]
        private IWebElement ShippingConfirmation;

        [FindsBy(How.XPath, "//ul/li[@class='step_current last']/span")]
        private IWebElement PaymentConfirmation;




        #endregion

        #region Public methods
        /**public WomenProductsPage ClickOnWomenProductTab()
        {
            WomenTab.Click();
            return WomenProductsPage;
        }**/

        public CheckoutPage ClickOnProceedSummary()
        {
            Wait();
            LogHelper.Write("Clicking on Proceed Summary");
            ProceedSummary.Click();
            return CheckoutPage;
        }

        public CheckoutPage ClickOnProceedAddress()
        {
            Wait();
            LogHelper.Write("Clicking on Proceed Address");
            ProceedAddress.Click();
            return CheckoutPage;
        }

        public CheckoutPage ClickOnTOSCheckbox()
        {
            Wait();
            LogHelper.Write("Clicking on TOS Check box");
            TOSCheckbox.Click();
            return CheckoutPage;
        }

        public CheckoutPage ClickOnProceedShipping()
        {
            Wait();
            LogHelper.Write("Clicking on Proceed Shipping");
            ProceedShipping.Click();
            return CheckoutPage;
        }

        public CheckoutPage ClickOnBankwire()
        {
            Wait();
            LogHelper.Write("Clicking on Bank wire");
            Bankwire.Click();
            return CheckoutPage;
        }

        public CheckoutPage ClickConfirmOrder()
        {
            Wait();
            LogHelper.Write("Clicking on Confirm Order");
            ConfirmationButton.Click();
            return CheckoutPage;
        }

        public Boolean VerifyCompletion()
        {
            Wait();
            return OrderConfirmationText.Displayed;
        }

        public Boolean VerifySummaryIsDisplayed()
        {
            return SummaryConfirmation.Displayed;
        }

        public Boolean VerifyAddressIsDisplayed()
        {
            return AddressConfirmation.Displayed;
        }

        public Boolean VerifyShippingIsDisplayed()
        {
            return ShippingConfirmation.Displayed;
        }

        public Boolean VerifyPaymentIsDisplayed()
        {
            return PaymentConfirmation.Displayed;
        }
        #endregion

        #region Private methods
        #endregion
    }
}
