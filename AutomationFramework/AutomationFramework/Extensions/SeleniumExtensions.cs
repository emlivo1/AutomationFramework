using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Extensions
{
    public static class SeleniumExtensions
    {
        public static bool IsDisplayed(this IWebElement element, int timeToWait)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool isDisplayed = false;

            while (!isDisplayed)
            {
                try
                {
                    if (element.Displayed)
                        return true;
                }
                catch (Exception)
                {
                    if (stopwatch.Elapsed.TotalSeconds > timeToWait)
                        return false;
                }
            }
            return true;

        }

    }
}
