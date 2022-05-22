
using InfrastructureAutomationLogin.BaseData;
using InfrastructureAutomationLogin.Flows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using Test.Tests;
using ZichronMenachemAutomation.BaseData;
using ZichronMenachemAutomation.Flows;

namespace InfrastructureAutomationLogin.Tests
{
    [TestFixture]
    public class RegistartDonorTest : WebDriverFactory
    {

        BaseFunctions baseFunctions;
        DonorFlow donorFlow;

        [SetUp]
        public void BeforTest()
        {
            //-------random text for user
            string RandomString(int size, bool lowerCase = false)
            {
                Random _random = new Random();

                var builder = new StringBuilder(size);

                // Unicode/ASCII Letters are divided into two blocks
                // (Letters 65–90 / 97–122):
                // The first group containing the uppercase letters and
                // the second group containing the lowercase.  

                // char is a single Unicode character  
                char offset = lowerCase ? 'a' : 'A';
                const int lettersOffset = 26; // A...Z or a..z: length=26  

                for (var i = 0; i < size; i++)
                {
                    var @char = (char)_random.Next(offset, offset + lettersOffset);
                    builder.Append(@char);
                }

                return lowerCase ? builder.ToString().ToLower() : builder.ToString();


            }
            //-------random ext end

        }
        [Test]
        //login as an admin
        public void _RegistartDonorTest()
        {
            donorFlow = new DonorFlow(driver);

            driver.Navigate().GoToUrl("https://zm-donor-qa.web.app/donate");
            donorFlow.RegistarDonorFlow();

           
        }

   /*     public void AfterTest()
        {
            driver.Close();

        }
*/
    }
}
