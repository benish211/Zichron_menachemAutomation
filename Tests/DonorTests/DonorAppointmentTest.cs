
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Test.Tests;
using ZichronMenachemAutomation.Flows;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class DonorAppointmentTest : WebDriverFactory
    {

        LoginFlow loginFlow;
        DonorFlow donorFlow;
        private string appointmentTime = "11:00";
        private string donorEmail = "tsg.benish@gmail.com";
        private string donorPassword = "qw762031";


        [SetUp]
        public void BeforTest()
        {
            loginFlow = new LoginFlow(driver);
            donorFlow = new DonorFlow(driver);

           
        }

        [Test]
        public void _DonorAppointmentTest()
        {
            donorFlow.DonorAppointment(appointmentTime);
            //donorFlow.VarificationEmailAppointment(donorEmail);

        }

        public void AfterTest()
        {
            driver.Close();

        }

    }
}
