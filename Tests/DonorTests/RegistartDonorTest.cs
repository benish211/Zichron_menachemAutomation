
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
    public class RegistartDonorTest : WebDriverFactory
    {

        string donorName = "testFname";
        string donorFamily = "testfamily";
        string donorPhoneNumber = "0584102220";
       
        string donorGmail = "testZichronMenachem@gmail.com";

        string donorGmailPasswor = "Qa762031!";
        public string dateAppointmant = "29/05/2022";

        DonorFlow donorFlow;
        BaseFunction baseFunction;

        [SetUp]
        public void BeforTest()
        {
            donorFlow = new DonorFlow(driver);
            baseFunction = new BaseFunction();

        }

        [Test]
        //login as an admin
        public void _RegistartDonorTest()
        {

            string userStringRamdom = baseFunction.RandomString(4, true);


            //Full all donor details for registar
            string donorFullEmail = "testZichronMenachem+" + userStringRamdom + "@gmail.com";
            donorFlow.RegistarDonorFlow(donorFullEmail, "123456",
               donorName, donorFamily, donorPhoneNumber);

        }

        public void AfterTest()
        {
           

        }

    }
}
