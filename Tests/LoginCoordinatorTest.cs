
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

            loginFlow.LoginCoordinator("tsg.benish@gmail.com", "qw762031");

        }

        public void AfterTest()
        {

            driver.Close();
        }

    }
}
