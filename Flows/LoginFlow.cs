using InfrastructureAutomationLogin.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.Flows
{
    public class LoginFlow
    {
        IWebDriver _driver;
        LoginDonorPage loginDonorPage;
        LoginCoordinatorPage loginCoordinatorPage;

        public LoginFlow(IWebDriver driver)
        {
            _driver = driver;
            loginDonorPage = new LoginDonorPage(_driver);
            loginCoordinatorPage = new LoginCoordinatorPage(_driver);

        }

        public void LoginDonor(string userName, string password)
        {
            Thread.Sleep(4000);
          
            loginDonorPage.SendUsername(userName);
            loginDonorPage.SendSendPassword(password);
            loginDonorPage.ClickLogin();
        }

        public void LoginCoordinator(string userName, string password)
        {
            Thread.Sleep(6000);

            loginCoordinatorPage.SendUsername(userName);
            loginCoordinatorPage.SendSendPassword(password);
            loginCoordinatorPage.ClickLogin();
        }

        public bool isloginSuccess()
        {
            Thread.Sleep(2000);
            return loginDonorPage.isIconDispay();
            
        }

        
    }
}
