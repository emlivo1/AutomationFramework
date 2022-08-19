using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Pages
{
    public class WomenProductsPage : Navigator
    {
        #region Elements
        [FindsBy(How.XPath, "//*[@class='subcategory-image']//*[@title='Tops']")]
        private IWebElement Tops;

        [FindsBy(How.XPath, "//*[@class='subcategory-image']//*[@title='Dresses']")]
        private IWebElement Dresses;

        [FindsBy(How.XPath, "//*[@class='grower CLOSE']")]
        private IWebElement ExpandTops;

        #endregion

        #region Public methods
        public WomenProductsPage ExpandTopsSection()
        {
            ExpandTops.Click();
            return this;
        }
        #endregion

        #region Private methods
        #endregion
    }
}
