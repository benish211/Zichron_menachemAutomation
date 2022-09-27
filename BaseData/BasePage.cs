
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace InfrastructureAutomationLogin.BaseData
{
    public class BasePage

    {
        IWebDriver _driver;
        public IWebDriver driver;
        public TimeSpan timeOutInSeconds = TimeSpan.FromSeconds(20);




        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }


        public void waitForElementVisibility(By el)
        {
            WebDriverWait wait = new WebDriverWait(_driver, timeOutInSeconds);
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(el));

        }
        public void waitForElementClickable(By el)
        {
            WebDriverWait wait = new WebDriverWait(_driver, timeOutInSeconds);
            wait.Until(ExpectedConditions.ElementToBeClickable(el));

        }
        public void click(By el)
        {
            waitForElementClickable(el);
            _driver.FindElement(el).Click();

        }
        public void fillText(By el, String text)
        {
            waitForElementClickable(el);
            _driver.FindElement(el).Click();
            _driver.FindElement(el).SendKeys(text);

        }
        public Boolean isDisplayed(IWebElement el)
        {
            try
            {
                waitForElementVisibility((By)el);
                return el.Displayed;
            }
            catch (WebDriverException e)
            {
                return false;
            }
        }
        public void alertOK()
        {
            _driver.SwitchTo().Alert().Accept();
        }
        public String getTextFromAt(IWebElement el, String att)
        {
            isDisplayed(el);
            return el.GetAttribute(att);
        }





    }
}

