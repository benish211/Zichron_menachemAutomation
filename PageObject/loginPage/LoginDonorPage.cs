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
        By userNameBy = By.XPath("//input[@id='mui-1']");
        By passwordBy = By.XPath("//input[@id='mui-2']");
        By IconBy = By.Id("lottie");

        IWebDriver _driver;
        public LoginDonorPage(IWebDriver driver)
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

        public bool isIconDispay()
        {
            _driver.FindElement(By.Id("lottie"));
            return true;
        }
    }
}
