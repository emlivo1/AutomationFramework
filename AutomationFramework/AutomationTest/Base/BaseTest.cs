using AutomationFramework.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFramework.Data;

namespace AutomationTest.Base
{
    public class BaseTest
    {
        // data that will be used for filling in forms
        public Data database = new Data();
        

        [TestInitialize]
        public void TestInitialize()
        {
            Navigator.InitalizePages();
          
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Navigator.QuitDriver();
        }

    }
}
