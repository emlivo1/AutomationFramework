using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using AutomationFramework.Helpers;

namespace AutomationFramework.Pages
{
    public class HomePage : Navigator
    {

        #region Elements
        [FindsBy(How.XPath, "//*[@title='Women']")]
        private IWebElement WomenTab;

        [FindsBy(How.ClassName, "homefeatured")]
        private IWebElement Popular;

        [FindsBy(How.XPath, "//ul[@id='homefeatured']//a[contains(text(), 'Blouse')]/ancestor::div[@class='product-container']//a[@data-id-product='2']")]
        private IWebElement AddToCartButton;

        [FindsBy(How.XPath, "//*[@title='Log me out']")]
        private IWebElement SignOutButton;

        [FindsBy(How.XPath, "//*[@title='View my customer account']")]
        private IWebElement MyAccountButton;

        [FindsBy(How.XPath, "//*[@title='Proceed to checkout']")]
        private IWebElement ProceedToCheckOutButton;

        [FindsBy(How.XPath, "//*[@title='Continue shopping']")]
        private IWebElement ContinueShoppingButton;



        [FindsBy(How.XPath, "//a[contains(text(), 'Blouse')]/ancestor::div[@class='product-container']")]
        private IWebElement FirstClothesCard;

       



        #endregion

        #region Public methods
        public WomenProductsPage ClickOnWomenProductTab()
        {
            WomenTab.Click();
            return WomenProductsPage;
        }


        public HomePage ClickOnAddToCart()
        {
            //CustomWait(AddToCartButton);
            Wait(30);
            LogHelper.Write("Clicking on Add to Cart");
            Actions action = new Actions(GuiUtils.Driver);
            action.MoveToElement(FirstClothesCard).Build().Perform(); 
            AddToCartButton.Click();
           


            return HomePage;
        }
        public MyAccountPage ClickOnMyAccount()
        {
            Wait();
            LogHelper.Write("Clicking on My Account");
            MyAccountButton.Click();


            return MyAccountPage;
        }
        public CheckoutPage ClickOnProceedToCheckout()
        {
            Wait(30); 
            LogHelper.Write("Clicking on Proceed to Check out");
            ProceedToCheckOutButton.Click();
            Wait();

            return CheckoutPage;
        }
        public HomePage ClickOnContinueShopping()
        {

            Wait() ;
            LogHelper.Write("Clicking on Continue to shopping");
            ContinueShoppingButton.Click();
            return this;
        }



        #endregion

        #region Private methods
        #endregion
    }
}
