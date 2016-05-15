using Example.WebAutomationTests.Helpers;
using Example.WebAutomationTests.Support;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Example.WebAutomationTests.Hooks
{
    [Binding]
    public sealed class JqueryUIHooks
    {
        private IWebDriver driver = null;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("Jquery")]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
             driver = WebDriverFactory.Create();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            if (driver!=null)
            {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
