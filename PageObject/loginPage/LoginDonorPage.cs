using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureAutomationLogin.PageObject
{
    public class LoginDonorPage
    {
        By buttonLoginBy = By.XPath("//*[contains(text(),'התחברות')]");
        By LoginEmailFeildBy = By.XPath("//input[@type='email']");
        By LoginPasswordFeildBy = By.XPath("//input[@type='password']");
        By IconBy = By.Id("lottie");

        IWebDriver _driver;
        public LoginDonorPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void SendUsername(string username)
        {
            _driver.FindElement(LoginEmailFeildBy).SendKeys(username);

        }
        public void SendSendPassword(string password)
        {
            _driver.FindElement(LoginPasswordFeildBy).SendKeys(password);

        }
        public void ClickLogin()
        {
            _driver.FindElement(buttonLoginBy).Click();

        }

        public bool isIconDispay()
        {
            _driver.FindElement(By.XPath("//img[@alt='Blood Bank']"));
            return true;
        }

        

    }
}
