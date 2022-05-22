
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Tests;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class LoginCoordinatorTest : WebDriverFactory
    {
        LoginFlow loginFlow;
        [SetUp]
        public void BeforTest()
        {


        }

        [Test]
        //login as an admin
        public void _LoginCoordinatorTest()
        {
            loginFlow = new LoginFlow(driver);
            //Setting up and initializing the drivers -- should to move intu base driver
            //ChromeOptions chromeFunctions = new ChromeOptions();
            driver.Navigate().GoToUrl("https://zm-admin-qa.web.app/");

            loginFlow.LoginCoordinator("ben1@g.com", "123456");

            bool isLoginSUccedd =
                loginFlow.isloginSuccess();

            Assert.True(isLoginSUccedd,
                "The login is success",
                "Login dont success- icon isnt display");
        }

        public void AfterTest()
        {

            driver.Close();
        }

    }
}
