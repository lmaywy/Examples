using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using Examples.Web.AcceptanceTests.Helpers;

namespace Examples.Web.AcceptanceTests.Support
{
    public class WebDriverFactory
    {
        public static RemoteWebDriver Create()
        {
            var browser = ConfigHelper.DriverToUse;
            RemoteWebDriver driver = null;
            var path = Environment.CurrentDirectory + @"\\Support";

            switch (browser)
            {
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    driver = new InternetExplorerDriver(path);
                    break;
                case "Chrome":
                    driver = new ChromeDriver(path);
                    break;
                default:
                    break;
            }

            var options = driver.Manage();
            var timeouts = options.Timeouts();

            options.Window.Maximize();
            timeouts.ImplicitlyWait(ConfigHelper.ImplicitlyWait);
            timeouts.SetPageLoadTimeout(ConfigHelper.PageLoadTimeout);

            return driver;
        }
    }
}
