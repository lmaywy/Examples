using Examples.Web.AcceptanceTests.Helpers;
using Examples.Web.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Web.AcceptanceTests.Support
{
    public class WebDriverUtils
    {
        private static Dictionary<How, Func<string, By>> selectors = new Dictionary<How, Func<string, By>>
                        {
                            { How.Id, By.Id},
                            { How.Name, By.Name},
                            { How.TagName, By.TagName},
                            { How.ClassName, By.ClassName},
                            { How.LinkText, By.LinkText},
                            { How.PartialLinkText, By.PartialLinkText},
                            { How.CssSelector, By.CssSelector},
                            { How.XPath, By.XPath}
                        };

        public static bool IsElementOnDOM(BasePage ele, IWebDriver driver, string propertyName)
        {
            By by = null;
            var type = ele.GetType();
            var property = type.GetProperties().First(c => c.Name == propertyName && c.PropertyType == typeof(IWebElement));
            var findsbyAttr = property.GetCustomAttributes(true).First(c => c.GetType() == typeof(FindsByAttribute)) as FindsByAttribute;

            if (findsbyAttr != null)
            {
                by = selectors[findsbyAttr.How].Invoke(findsbyAttr.Using);
            }

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(0));
            var isExisted = driver.FindElements(by).Count() > 0;
            driver.Manage().Timeouts().ImplicitlyWait(ConfigHelper.ImplicitlyWait);
            return isExisted;
        }

       
    }
}
