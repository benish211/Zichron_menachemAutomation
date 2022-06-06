using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZichronMenachemAutomation.PageObject.CordinatoorPages;

namespace ZichronMenachemAutomation.Flows
{
    public class CordinatoorFlow
    {

        IWebDriver _driver;
        CordinatoorSchedulePage cordinatoorSchedulePage;

        public CordinatoorFlow(IWebDriver driver)
        {
            _driver = driver;
            cordinatoorSchedulePage = new CordinatoorSchedulePage(_driver);
        }

        public void CreateAppointment()
        {
            Thread.Sleep(9000);
            cordinatoorSchedulePage.ClickAddAppointment();
        }

        //get the appointment date
        public string getAppointmentDate()
        {
            Thread.Sleep(1000);
            return cordinatoorSchedulePage.GetAppointmentDate();    
        }
        //get the appointment time
        public string getAppointmentTime()
        {
            Thread.Sleep(1000);
            return cordinatoorSchedulePage.GetAppointmentTime();
        }

        //complete appointment
        public void CompleteAppointmentAdding()
        {
            Thread.Sleep(1000);
            cordinatoorSchedulePage.ClickAddTOAppointment();
            cordinatoorSchedulePage.ClickApproveAndContinue();

        }

    }
}
