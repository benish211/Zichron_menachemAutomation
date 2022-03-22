
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Tests;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class LoginTest : WebDriverFactory
    {
        LoginFlow loginFlow;



        [Test]
        //login as an admin
        public void _LoginTest()
        {
            
            //Setting up and initializing the drivers -- should to move intu base driver
            //ChromeOptions chromeFunctions = new ChromeOptions();
            driver.Navigate().GoToUrl("https://packlogin.lightico.com/");

            loginFlow = new LoginFlow(driver);
            loginFlow.Login("bennys4@lightico.com", "Aa123456");

            driver.Close();
        }


    }
}
