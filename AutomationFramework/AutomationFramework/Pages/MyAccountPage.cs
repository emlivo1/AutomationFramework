using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class MyAccountPage : Navigator
    {
        [FindsBy(How.XPath, "//span[text()='My account']")]
        private IWebElement MyAccountBreadcrumb;
        public Boolean VerifyMyAccountShown()
        {
            return MyAccountBreadcrumb.Displayed;
        }
    }
}
