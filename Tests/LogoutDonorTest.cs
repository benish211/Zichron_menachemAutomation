
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Tests;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class LogoutDonorTest : WebDriverFactory
    {

        LoginFlow loginFlow;
        string donorGmail = "automation@g.com";
        string donorGmailPasswor = "123456";

        [SetUp]
        public void BeforTest()
        {

        }

        [Test]
        //login as an admin
        public void _LogoutDonorTest()
        {

            //Setting up and initializing the drivers -- should to move intu base driver
            //ChromeOptions chromeFunctions = new ChromeOptions();

            loginFlow = new LoginFlow(driver);
            loginFlow.LoginDonor(donorGmail, donorGmailPasswor);


            bool isLoginSUccedd =
                loginFlow.isloginDonorSuccess();

            Assert.True(isLoginSUccedd,
                "The login is success",
                "Login dont success- icon isnt display");

            loginFlow.LogoutDonor();
        }

        public void AfterTest()
        {
            driver.Close();
        }

    }
}
