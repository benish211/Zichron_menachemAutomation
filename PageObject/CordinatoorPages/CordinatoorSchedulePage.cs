using InfrastructureAutomationLogin.BaseData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZichronMenachemAutomation.PageObject.CordinatoorPages
{
    public class CordinatoorSchedulePage:BasePage
    {

        By AddAppointmentButtonBy = By.CssSelector(".AddAppointmentFab_text__nhfKL");
        By AppointmentDateBy = By.CssSelector(".MuiTextField-root.muirtl-i44wyl:nth-child(1) .muirtl-mnn31");
        By AppointmentTimeBy = By.CssSelector(".MuiTextField-root.muirtl-i44wyl:nth-child(2) .muirtl-mnn31");
        By ClickAddTOAppointmentBy = By.CssSelector(".AddAppointmentScreen_fullRowField__-Vy97 .Button_buttonText__gCGff");
        By ClickApproveAndContinueBy = By.CssSelector(".AddAppointmentScreen_actionButtons__KPJBM .muirtl-1i3my2h");
        By checkApproveappoiment = By.CssSelector(".CoordinatorHeader_title__S6SqJ.CoordinatorHeader_infoTitle__zvzxX");


        IWebDriver _driver;


        public CordinatoorSchedulePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            { }
        }
        public void ClickAddAppointment()
        {
            click(AddAppointmentButtonBy);
        }

        public string  GetAppointmentDate()
        {          
            IWebElement dateElement = _driver.FindElement(AppointmentDateBy);
            return dateElement.GetAttribute("value"); ;
        }
        public string GetAppointmentTime()
        {
            IWebElement dateElement = _driver.FindElement(AppointmentTimeBy);
            return dateElement.GetAttribute("value");
        }

        public void ClickAddTOAppointment()
        {
            click(ClickAddTOAppointmentBy);
        }
        public void ClickApproveAndContinue()
        {
            click(ClickApproveAndContinueBy);
            waitForElementVisibility(checkApproveappoiment);
        }
    }
}
