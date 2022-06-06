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

    public class DonorRemoveQueue : WebDriverFactory
    {
        LoginFlow loginFlow;
        DonorFlow donorFlow;
        CordinatoorFlow cordinatoorFlow;
        BaseFunction baseFunction;
        string cordinatoorUser= "tsg.benish@gmail.com";
        string cordinatoorPasswor = "qw762031";
        string donorGmail = "automation@g.com";
        string donorGmailPasswor = "123456";

        string donorName = "testFname";
        string donorFamily = "testfamily";
        string donorPhoneNumber = "0584102220";


        [SetUp]
        public void BeforTest()
        {
            loginFlow = new LoginFlow(driver);
            cordinatoorFlow = new CordinatoorFlow(driver);
            donorFlow = new DonorFlow(driver);
            baseFunction = new BaseFunction();

            string userStringRamdom = baseFunction.RandomString(4, true);

            loginFlow.LoginCoordinator(cordinatoorUser, cordinatoorPasswor);

        }

        [Test]
        //login as an admin
        public void _DonorRemoveQueue()
        {
            //make appointment via cordinatoor
            cordinatoorFlow.CreateAppointment();

            string dateAppointment = cordinatoorFlow.getAppointmentDate();
            string timeAppointment = cordinatoorFlow.getAppointmentTime();

            Console.WriteLine("appointemt date " + dateAppointment);
            Console.WriteLine("appointemt time " + timeAppointment);

            cordinatoorFlow.CompleteAppointmentAdding();


            string userStringRamdom = baseFunction.RandomString(4, true);


            //Full all donor details for registar
            string donorFullEmail = "testZichronMenachem+" + userStringRamdom + "@gmail.com";
            donorFlow.RegistarDonorFlow(donorFullEmail, "123456",
               donorName, donorFamily, donorPhoneNumber);

            donorFlow.DonorAppointment(timeAppointment);

            donorFlow.donorRemoveQueue();

        }


        public void AfterTest()
        {

        }

    }
}
