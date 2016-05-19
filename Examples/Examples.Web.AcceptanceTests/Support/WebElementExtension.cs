using Examples.Web.AcceptanceTests.Helpers;
using OpenQA.Selenium;
using System;

namespace Examples.Web.AcceptanceTests.Support
{
    public static class WebElementExtension
    {
        public static bool IsElementPresent(this IWebElement ele, IWebDriver driver)
        {
            var isPresent = false;
            try
            {
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
                var ret = ele.Displayed;
                driver.Manage().Timeouts().ImplicitlyWait(ConfigHelper.ImplicitlyWait);
            }
            catch (Exception ex)
            {
                isPresent = false;
            }

            return isPresent;
        }
    }
}
