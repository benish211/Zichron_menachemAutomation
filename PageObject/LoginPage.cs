using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.PageObject
{
    public class LoginPage
    {
        By buttonLoginBy = By.Id("buttonLogIn");
        By userNameBy = By.Id("Username");
        By passwordBy = By.Id("Password");

        IWebDriver _driver;
        public LoginPage(IWebDriver driver)
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
