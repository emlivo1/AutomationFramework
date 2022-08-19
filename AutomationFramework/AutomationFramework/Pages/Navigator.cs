using AutomationFramework.Helpers;
using AutomationFramework.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationFramework.Extensions;

namespace AutomationFramework.Pages
{
    public class Navigator
    {
        #region Properties
        protected static HomePage HomePage { get; set; }
        protected static WomenProductsPage WomenProductsPage { get; set; }
        protected static CheckoutPage CheckoutPage { get; set; }
        protected static SignInPage SignInPage { get; set; }
        protected static MyAccountPage MyAccountPage { get; set; }

        protected static RegistrationPage RegistrationPage { get; set; }

        #endregion



        #region elements
        [FindsBy(How.XPath, "//a[@title='My Store']")]
        private IWebElement Logo;

        [FindsBy(How.ClassName, "login")]
        private IWebElement SignInButton;

        [FindsBy(How.XPath, "//*[@title='Log me out']")]
        private IWebElement SignOutButton;

        [FindsBy(How.XPath, "//*[@title='goda']")]
        private IWebElement GodaButton;
        #endregion

        #region Constructors
        public Navigator()
        {
            if (GuiUtils.Driver == null)
                InitalizeBrowser();
            LogHelper.CreateLogFile();

            PageFactory.InitElements(GuiUtils.Driver, this);

        }
        #endregion

        #region Public methods
        public HomePage ClickOnLogo()
        {
            LogHelper.Write("Clicking on Logo");
            Logo.Click();
            return HomePage;
        }
        public static HomePage OpenHomepage()
        {
            LogHelper.Write("Clicking on opening Home Page");
            return HomePage;
        }

        public static MyAccountPage GetMyAccountPage()
        {

            return MyAccountPage;
        }

        public static CheckoutPage GetCheckoutPage()
        {
            return CheckoutPage;
        }
        public static void InitalizePages()
        {
            HomePage = new HomePage();
            WomenProductsPage = new WomenProductsPage();
            CheckoutPage = new CheckoutPage();
            SignInPage = new SignInPage();
            MyAccountPage = new MyAccountPage();
            RegistrationPage = new RegistrationPage();
        }

        public static void InitalizeBrowser(string browser = "Chrome")
        {
            if (browser == "Chrome")
                GuiUtils.Driver = new ChromeDriver();
            else if (browser == "Edge")
                GuiUtils.Driver = new EdgeDriver();

            GuiUtils.Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            GuiUtils.Driver.Manage().Window.Maximize();
        }

        public SignInPage ClickOnSignIn()
        {
            LogHelper.Write("Clicking on Sign In");
            SignInButton.Click();
            return SignInPage;
        }

        public HomePage ClickOnSignOut()
        {
            Wait();
            LogHelper.Write("Clicking on Sign Out");
            SignOutButton.Click();
            return HomePage;
        }

        public static void Wait(int WaitTime=1)
        {
            GuiUtils.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WaitTime);
        }

      

        
         public void CustomWait(IWebElement element, int time=15)
         {
            while (time != 0)
            {
                try
                {

                    if (element.Displayed == true)
                    {
                        LogHelper.Write("bravo");
                        break;
                    }
                    else
                    {
                        LogHelper.Write("zglibio");
                        throw new StaleElementReferenceException();
                    }
                }
                catch (StaleElementReferenceException e)
                {
                    LogHelper.Write("cekam");
                    Wait(1);
                    time = time - 1;
                    continue;
                }
            }
           

         }
        
        public static void QuitDriver()
        {
            GuiUtils.Driver.Quit();
        }
        #endregion


        #region Private methods

        #endregion

    }
}
