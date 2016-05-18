using Examples.Web.AcceptanceTests.Pages.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Web.AcceptanceTests.Pages
{
    public class JqueryUIThemePage : BasePage
    {
        public JqueryUIThemePage(IWebDriver driver)
            : base(driver)
        {
            this.Url = "http://jqueryui.com/themeroller/";
        }

        #region elements

        [FindsBy(How = How.CssSelector, Using = "#themeroller-content .entry-title")]
        public IWebElement EntryTitle { get; set; }

        [FindsBy(How = How.Id, Using = "accordion")]
        public IWebElement Accordion { get; set; }
        #endregion
    }
}
