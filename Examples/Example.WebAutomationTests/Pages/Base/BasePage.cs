using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Example.WebAutomationTests.Pages.Base
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            this.WebDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public string Url { get; set; }
        public string Title { get; set; }
        public IWebDriver WebDriver { get; set; }

        public virtual void GoTo()
        {
            WebDriver.Url = this.Url;
        }
    }
}
