using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Text;

namespace Test.Tests
{
    /// <summary>
    /// A static factory object for creating WebDriver instances
    /// </summary>
    public class WebDriverFactory
    {
        // public  IWebDriver driver;
        public IWebDriver driver;
      

        public  WebDriverFactory()
        {

            driver = WebDriver(BrowserType.Chrome);

           
        }

        


        /// <summary>
        /// Types of browser available for proxy examples.
        /// </summary>
        public enum BrowserType
        {
            IE,
            Chrome,
            Firefox,
            PhantomJS
        }

        public static IWebDriver WebDriver(BrowserType type)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case BrowserType.IE:
                    driver = IeDriver();
                    break;
                case BrowserType.Firefox:
                    driver = FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    driver = ChromeDriver();
                    break;
                default:
                    driver = ChromeDriver();
                    break;
            }

            return driver;
        }

        /// <summary>
        /// Creates Internet Explorer Driver instance.
        /// </summary>
        /// <returns>A new instance of IEDriverServer</returns>
        private static IWebDriver IeDriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.EnsureCleanSession = true;
            IWebDriver driver = new InternetExplorerDriver(options);
            return driver;
        }

        /// <summary>
        /// Creates Firefox Driver instance.
        /// </summary>
        /// <returns>A new instance of Firefox Driver</returns>
        private static IWebDriver FirefoxDriver()
        {
            FirefoxProfile profile = new FirefoxProfile();
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }


        /// <summary>
        /// Creates Chrome Driver instance.
        /// </summary>
        /// <returns>A new instance of Chrome Driver</returns>
        private static IWebDriver ChromeDriver()
        {
            //ChromeOptions chromeOptions = new ChromeOptions();
            IWebDriver driver = new ChromeDriver();

            return driver;
        }

        [TearDown]
        public void TestFixtureTearnDown()
        {
            driver.Quit();
        }


    }
}