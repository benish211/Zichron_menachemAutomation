
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace InfrastructureAutomationLogin.BaseData
{
    public class BaseFunction

    {
        WebDriver driver;
        WebDriverWait wait;

        //public BaseFunction(WebDriver driver)
        //{
        //    this.driver = driver;
        //    wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //}

        //-------random text for donor email
        public string RandomString(int size, bool lowerCase = false)
        {
            Random _random = new Random();
            var builder = new StringBuilder(size);
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


        protected void waitForVisibleOfElement(By el)
        {
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(el));
        }

        protected void waitForClickableElement(WebElement el)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(el));
        }




    }
}

