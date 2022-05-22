
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Tests;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class LoginDonorTest : WebDriverFactory
    {

        LoginFlow loginFlow;

        
        [SetUp]
        public void BeforTest()
        {

        }

        [Test]
        //login as an admin
        public void _LoginDonorTest()
        {
            
            //Setting up and initializing the drivers -- should to move intu base driver
            //ChromeOptions chromeFunctions = new ChromeOptions();
            driver.Navigate().GoToUrl("https://zm-donor-qa.web.app/login");

            loginFlow = new LoginFlow(driver);
            loginFlow.LoginDonor("tsg.benish@gmail.com", "qw762031");


            bool isLoginSUccedd= 
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
