using InfrastructureAutomationLogin.BaseData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.PageObject
{
    public class LoginDonorPage: BasePage
    {
        By buttonLoginBy = By.XPath("//*[contains(text(),'התחברות')]");
        By LoginEmailFeildBy = By.XPath("//input[@type='email']");
        By LoginPasswordFeildBy = By.XPath("//input[@type='password']");
        By IconBy = By.Id("lottie");

        IWebDriver _driver;

        public LoginDonorPage(IWebDriver driver):base(driver)
        {
            _driver = driver;
            { }
        }
        public void SendUsername(string username)
        {
            fillText(LoginEmailFeildBy, username);

        }
        public void SendSendPassword(string password)
        {
            fillText(LoginPasswordFeildBy, password);
        }
        public void ClickLogin()
        {
            click(buttonLoginBy);
        }

        public bool isIconDispay()
        {
            _driver.FindElement(By.XPath("//img[@alt='Blood Bank']"));
            return true;
        }       
    }
}
