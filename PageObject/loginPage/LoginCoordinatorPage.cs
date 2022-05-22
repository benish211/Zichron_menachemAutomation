using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.PageObject
{
    public class LoginCoordinatorPage
    {
        By buttonLoginBy = By.XPath("//div[@class='Button_buttonText__gCGff']");
        By userNameBy = By.XPath("//input[@id='mui-1']");
        By passwordBy = By.XPath("//input[@id='mui-2']");

        IWebDriver _driver;
        public LoginCoordinatorPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SendUsername(string username)
        {
            _driver.FindElement(userNameBy).SendKeys(username);

        }
        public void SendSendPassword(string password)
        {
            _driver.FindElement(passwordBy).SendKeys(password);

        }
        public void ClickLogin()
        {
            _driver.FindElement(buttonLoginBy).Click();

        }
    }
}
