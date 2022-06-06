
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using Test.Tests;
using ZichronMenachemAutomation.Flows;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]

    public class E2ETest : WebDriverFactory
    {
        LoginFlow loginFlow;
        DonorFlow donorFlow;
        CordinatoorFlow cordinatoorFlow;
        BaseFunction baseFunction;
        string datetest;

        string donorName = "testFname";
        string donorFamily = "testfamily";
        string donorPhoneNumber = "0584102220";
      
        string donorGmail = "testZichronMenachem@gmail.com";

        string donorGmailPasswor = "Qa762031!";


        [SetUp]
        public void BeforTest()
        {
            loginFlow = new LoginFlow(driver);
            cordinatoorFlow = new CordinatoorFlow(driver);
            donorFlow = new DonorFlow(driver);
            baseFunction = new BaseFunction();

            string userStringRamdom = baseFunction.RandomString(4, true);

            loginFlow.LoginCoordinator("tsg.benish@gmail.com", "qw762031");

        }

        [Test]
        //login as an admin
        public void _E2ETest()
        {
            //make appointment via cordinatoor
            cordinatoorFlow.CreateAppointment();

            string dateAppointment = cordinatoorFlow.getAppointmentDate();
            string timeAppointment = cordinatoorFlow.getAppointmentTime();

            Console.WriteLine("appointemt date " + dateAppointment);
            Console.WriteLine("appointemt time " + timeAppointment);

            cordinatoorFlow.CompleteAppointmentAdding();



            //donor registar
            //-------random text for donor email

            string userStringRamdom = baseFunction.RandomString(4, true);

            //Full all donor details
            string donorFullEmail = "testZichronMenachem+" + userStringRamdom + "@gmail.com";

            donorFlow.RegistarDonorFlow(donorFullEmail, "123456",
               donorName, donorFamily, donorPhoneNumber);

            //donor appointment
            donorFlow.DonorAppointment(timeAppointment);

            donorFlow.VarificationEmailAppointment(donorGmail,
                donorGmailPasswor, timeAppointment);

            //gmail verification
            donorFlow.isEmailAppointmantAccept(dateAppointment);

            bool isGemailAccept =
                donorFlow.isEmailAppointmantAccept(dateAppointment);

            Assert.True(isGemailAccept,
                "The Gmail appointmate recived",
                "The Gmail appointmate NOT recive");
        }
            public void AfterTest()
        {

            driver.Close();
        }
    }
}
