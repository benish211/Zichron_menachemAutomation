using InfrastructureAutomationLogin.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.Flows
{
    public class LoginFlow
    {
        IWebDriver _driver;
        LoginPage loginPage;

        public LoginFlow(IWebDriver driver)
        {
            _driver = driver;
            loginPage = new LoginPage(_driver);
        }

        public void Login(string userName, string password)
        {
            loginPage.SendUsername(userName);
            loginPage.SendSendPassword(password);
            loginPage.ClickLogin();

        }
    }
}
