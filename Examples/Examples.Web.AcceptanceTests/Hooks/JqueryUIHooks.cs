using Examples.Web.AcceptanceTests.Steps.Base;
using Examples.Web.AcceptanceTests.Support;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Examples.Web.AcceptanceTests.Hooks
{
    [Binding]
    public sealed class JqueryUIHooks : StepBase
    {
        private IWebDriver driver = null;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("Jquery")]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
             driver = WebDriverFactory.Create();
             Set(driver);
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
