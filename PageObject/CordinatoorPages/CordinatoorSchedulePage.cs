using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZichronMenachemAutomation.PageObject.CordinatoorPages
{
    public class CordinatoorSchedulePage
    {

        By AddAppointmentButtonBy = By.XPath("//div[contains(text(),'הוסף תור')]");
        By AppointmentDateBy = By.XPath("//input[@placeholder='dd/mm/yyyy']");
        By AppointmentTimeBy = By.XPath("//input[@placeholder='hh:mm']");
        By ClickAddTOAppointmentBy = By.XPath("//div[contains(text(),'הוספה')]");
        By ClickApproveAndContinueBy = By.XPath("//div[contains(text(),'אשר והמשך')]");


        IWebDriver _driver;
        public CordinatoorSchedulePage(IWebDriver driver)
        {
            _driver = driver;
            { }
        }

        public void ClickAddAppointment()
        {
            _driver.FindElement(AddAppointmentButtonBy).Click();
        }

        public string  GetAppointmentDate()
        {          
            IWebElement dateElement = _driver.FindElement(AppointmentDateBy);
            string dateValue = dateElement.GetAttribute("value");
            return dateValue;
        }
        public string GetAppointmentTime()
        {
            IWebElement dateElement = _driver.FindElement(AppointmentTimeBy);
            string dateValue = dateElement.GetAttribute("value");
            return dateValue;
        }

        public void ClickAddTOAppointment()
        {
            _driver.FindElement(ClickAddTOAppointmentBy).Click();
        }
        public void ClickApproveAndContinue()
        {
            _driver.FindElement(ClickApproveAndContinueBy).Click();
        }
    }
}
