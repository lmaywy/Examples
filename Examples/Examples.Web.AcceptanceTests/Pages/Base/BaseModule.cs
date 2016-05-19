using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Web.AcceptanceTests.Pages.Base
{
    public abstract class BaseModule
    {
        public IWebDriver WebDriver { get; set; }

        protected IWebElement Container { get; set; }

        public BaseModule(IWebElement element)
        {
            this.Container = element;
            PageFactory.InitElements(element, this);
        }
    }
}
