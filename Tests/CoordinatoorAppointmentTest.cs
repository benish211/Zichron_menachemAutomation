
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Test.Tests;
using ZichronMenachemAutomation.Flows;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]

    public class CoordinatoorAppointmentTest : WebDriverFactory
    {
        LoginFlow loginFlow;

        CordinatoorFlow cordinatoorFlow;
        string datetest;
        [SetUp]
        public void BeforTest()
        {
            loginFlow = new LoginFlow(driver);
            cordinatoorFlow = new CordinatoorFlow(driver);
            loginFlow.LoginCoordinator("tsg.benish@gmail.com", "qw762031");

        }

        [Test]
        //login as an admin
        public void _CoordinatoorAppointmentTest()
        {
          
            cordinatoorFlow.CreateAppointment();

           string dateAppointment = cordinatoorFlow.getAppointmentDate();
           string timeAppointment = cordinatoorFlow.getAppointmentTime();

            Console.WriteLine("the appointemt date " + dateAppointment);
            Console.WriteLine("the appointemt time " + timeAppointment);

            cordinatoorFlow.CompleteAppointmentAdding();
        }


        public void AfterTest()
        {

            driver.Close();
        }
    }
}
