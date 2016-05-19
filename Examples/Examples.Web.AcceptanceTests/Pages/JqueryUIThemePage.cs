using Examples.Web.AcceptanceTests.Pages.Base;
using Examples.Web.AcceptanceTests.Support;
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
        [FindsBy(How = How.CssSelector, Using = ".entry-title")]
        public IWebElement TitleContent { get; set; }

        [FindsBy(How = How.Id, Using = "accordion")]
        public IWebElement AccordionWidget { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='themeroller__demo-area']/descendant::input[@id='autocomplete']")]
        public IWebElement AutoCompleteWidget { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul.ui-autocomplete")]
        public IWebElement AutoCompleteTip { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul.ui-autocomplete>li")]
        public IList<IWebElement> AutoCompleteTipItems { get; set; }
        #endregion

        #region actions
        public bool AutoCompleteContains(string text)
        {
            return AutoCompleteTipItems.All(li => li.Text.Contains(text));
        }

        public void EnterTextToAutoComplete(string text)
        {
            AutoCompleteWidget.SendKeys(text);
            WebDriverUtils.MoveToElement(AutoCompleteTipItems.First(), this.WebDriver);
            
        }
        #endregion
    }
}
