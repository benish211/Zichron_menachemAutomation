using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Drawing;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace Test.Tests
{
    /// <summary>
    /// A static factory object for creating WebDriver instances
    /// </summary>
    public class WebDriverFactory
    {
        // public  IWebDriver driver;
        public IWebDriver driver;
        public TimeSpan timeOutInSeconds = TimeSpan.FromSeconds(20);



        public WebDriverFactory()
        {

            driver = WebDriver(BrowserType.Chrome);
            //driver.Manage().Window.Size = new Size(1920, 1080);
            driver.Manage().Window.Maximize();

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
            //        IWebDriver driver = new ChromeDriver($"D:/Benny/Automation/tools");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeDriver driver = new ChromeDriver();
            return driver;
        }

        [TearDown]
        public void TestFixtureTearnDown()
        {
            //driver.Quit();
        }


    }
}