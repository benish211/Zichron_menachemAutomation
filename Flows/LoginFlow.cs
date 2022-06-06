using InfrastructureAutomationLogin.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZichronMenachemAutomation.PageObject.DonorPages;
using ZichronMenachemAutomation.PageObject.RegistarPages;

namespace InfrastructureAutomationLogin.Flows
{
    public class LoginFlow
    {
        IWebDriver _driver;
        LoginDonorPage loginDonorPage;
        LoginCoordinatorPage loginCoordinatorPage;
        DonorRegistarPages donorRegistarPages;
        DonorDonatePage donorDonatePage;
        public LoginFlow(IWebDriver driver)
        {
            _driver = driver;
            loginDonorPage = new LoginDonorPage(_driver);
            donorRegistarPages = new DonorRegistarPages(_driver);
            loginCoordinatorPage = new LoginCoordinatorPage(_driver);
            donorDonatePage = new DonorDonatePage(driver);
        }

        public void LoginDonor(string userName, string password)
        {

            Thread.Sleep(3000);
            _driver.Navigate().GoToUrl("https://zm-donor-qa.web.app/login");

            // the login moved to donate page
           

            Thread.Sleep(3000);

            loginDonorPage.SendUsername(userName);
            loginDonorPage.SendSendPassword(password);
            loginDonorPage.ClickLogin();
        }
        public bool isloginDonorSuccess()
        {
            Thread.Sleep(3000);
            return loginDonorPage.isIconDispay();
        }

        public void LogoutDonor()
        {
            Thread.Sleep(1000);

            donorDonatePage.ClickHamburgerTab();
            Thread.Sleep(1000);

            donorDonatePage.ClicLogoutButton();
        }

        //cordinatoor flows:
        public void LoginCoordinator(string userName, string password)
        {
            _driver.Navigate().GoToUrl("https://zm-admin-qa.web.app/login");
            Thread.Sleep(3000);

            loginCoordinatorPage.SendUsername(userName);
            loginCoordinatorPage.SendSendPassword(password);
            loginCoordinatorPage.ClickLogin();
        }

       

        
    }
}
