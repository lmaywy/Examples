using Examples.Web.AcceptanceTests.Constants;
using Examples.Web.AcceptanceTests.Helpers;
using Examples.Web.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace Examples.Web.AcceptanceTests.Support
{
    public static class WebDriverExtension
    {

        public static IWebElement FindElementsByJquery(this IWebDriver driver, string selector)
        {
            var js = (IJavaScriptExecutor)driver;
            // inject jquery if required
            if ((bool)js.ExecuteScript("return typeof jQuery == 'undefined'"))
            {
                js.ExecuteScript(ScriptContext.AddJquery);
                Thread.Sleep(300);
            }
            var formattedSelector = selector.IndexOf("$(", StringComparison.InvariantCultureIgnoreCase) == -1 ?
                string.Format("$(\"{0}\")", selector.Replace('\"', '\'')) : selector;
            var wait = new WebDriverWait(driver, ConfigHelper.ImplicitlyWait);
            var elements = wait.Until(c => FindElements(driver, formattedSelector));

            if (!elements.Any())
            {
                throw new InvalidOperationException(string.Format(ExceptionMessage.ElementNotFound, formattedSelector));
            }
            if (elements.Count() > 1)
                throw new InvalidOperationException(string.Format(ExceptionMessage.MutipleElementsFound, formattedSelector));

            return elements.FirstOrDefault() as IWebElement;
        }


        private static IEnumerable<object> FindElements(IWebDriver driver, string selector)
        {
            const string ret = "return ";
            var result = ((IJavaScriptExecutor)driver).ExecuteScript(
                (selector.StartsWith(ret, StringComparison.InvariantCultureIgnoreCase) ? string.Empty : ret) + selector);
            return result as IEnumerable<object>;
        }
    }
}
