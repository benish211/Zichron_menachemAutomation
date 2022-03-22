
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.BaseData
{
    public class TestCaseBase
    {
  /*      public IWebDriver driver;

        // public IWebDriver driver { get; private set; }
        public TestCaseBase()
        {
            driver = new ChromeDriver("D:/Benny/Automation/tools");

        }*/
      /*  private void WebDriverType(BrowserType type)
        {
            driver = BrowserType.Chrome);
        }*/


        public enum BrowserType
        {
            Chrome,
            FireFox,
            InternetExplorer,
            Edge
        }
      
            private BrowserType SetBrowserType(string i_browser)
        {
            BrowserType browserType;
            switch (i_browser.ToLower())
            {
                case "chrome":
                    browserType = BrowserType.Chrome;
                    break;
                case "ie":
                case "internetexplorer":
                    browserType = BrowserType.InternetExplorer;
                    break;
                case "Edge":
                    browserType = BrowserType.Edge;
                    break;
                case "ff":
                case "firefox":
                    browserType = BrowserType.FireFox;
                    break;
                default:
                    browserType = BrowserType.Chrome;
                    break;
            }

            return browserType;
        }
    }
}

