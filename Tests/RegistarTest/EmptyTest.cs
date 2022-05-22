
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Tests;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class EmptyTest : WebDriverFactory
    {

        LoginFlow loginFlow;
        [SetUp]
        public void BeforTest()
        {

        }

        [Test]
        //login as an admin
        public void _EmptyTest()
        {

        }

        public void AfterTest()
        {
            driver.Close();

        }

    }
}
