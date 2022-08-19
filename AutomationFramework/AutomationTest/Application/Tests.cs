using AutomationFramework.Pages;
using AutomationTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFramework.Data;
using System;

namespace AutomationTest
{
    [TestClass]
    public class Tests : BaseTest
    {/**
        [TestMethod]
        public void ExpandTopsSection()
        {
            Navigator.OpenHomepage()
                .ClickOnWomenProductTab()
                .ExpandTopsSection();
        }**/


        [TestMethod]
        public void RegistrationCheck()
        {
            Navigator.OpenHomepage()
                .ClickOnSignIn()
                .CreateAccount(database.GenerateEmail())
                .Register(database.getDictionary());
            
            Assert.IsTrue(Navigator.GetMyAccountPage().VerifyMyAccountShown());
           
            Navigator.OpenHomepage()
                    .ClickOnSignOut()
                    .ClickOnLogo();

            // other method
            Navigator.OpenHomepage()
                    .ClickOnSignIn()
                    .LogIn(database.GetUniqueEmail(), database.getDictionary()["pass"])
                    .ClickOnLogo()
                    .ClickOnAddToCart()
                    .ClickOnProceedToCheckout()
                    .ClickOnProceedSummary()
                    .ClickOnProceedAddress()
                    .ClickOnTOSCheckbox()
                    .ClickOnProceedShipping()
                    .ClickOnBankwire()
                    .ClickConfirmOrder();
            
            Assert.IsTrue(Navigator.GetCheckoutPage().VerifyCompletion());
                
        }



    }
}
