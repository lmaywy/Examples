using Examples.Web.AcceptanceTests.Steps.Base;
using Examples.Web.AcceptanceTests.Support;
using OpenQA.Selenium;
using System.Runtime.InteropServices;
using TechTalk.SpecFlow;

namespace Examples.Web.AcceptanceTests.Hooks
{
    [Binding]
    public sealed class JqueryUIHooks : StepBase
    {
        private IWebDriver driver = null;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [DllImport("User32")]
        public extern static void SetCursorPos(int x, int y);

        [BeforeScenario("Jquery")]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
             driver = WebDriverFactory.Create();
             Set(driver);
             SetCursorPos(0, 0);
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
