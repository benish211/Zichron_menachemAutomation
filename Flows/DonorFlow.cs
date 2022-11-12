using InfrastructureAutomationLogin.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZichronMenachemAutomation.PageObject.DonorPages;
using ZichronMenachemAutomation.PageObject.RegistarPages;

namespace ZichronMenachemAutomation.Flows
{
    public class DonorFlow
    {
        IWebDriver _driver;
        DonorRegistarPages donorRegistarPages;
        DonorDonatePage donorDonatePage;

        public DonorFlow(IWebDriver driver)
        {
            _driver = driver;
            donorRegistarPages = new DonorRegistarPages(_driver);
            donorDonatePage = new DonorDonatePage(_driver);
            driver.Navigate().GoToUrl("https://zm-donor-qa.web.app/donate");

        }

        public void RegistarDonorFlow(string donorEmail, string donorPassword,
            string donorName, string donorFamily, string donorPhoneNumber)
        {
            _driver.Navigate().GoToUrl("https://zm-donor-qa.web.app/donate");

         //   Thread.Sleep(3000);
            donorRegistarPages.ClickEntryButton();
            donorRegistarPages.ClickRegistarButton();

           // Thread.Sleep(4000);
            donorRegistarPages.SendDonorEmail(donorEmail);
            donorRegistarPages.SendDonorPassword(donorPassword);
            donorRegistarPages.ClickRegistarDonorButton();

         //   Thread.Sleep(10000);
            donorRegistarPages.SendDonorName(donorName);
            donorRegistarPages.SendDonorFamily(donorFamily);
            donorRegistarPages.SendDonorPhoneNumber(donorPhoneNumber);
            donorRegistarPages.ClickBlodType();
            donorRegistarPages.ClickRegistarDonorCompleteButton();

         //   Thread.Sleep(9000);
            donorDonatePage.RegistrationDonorSuccess();
        }

        public void DonorAppointment(string time)
        {
            Thread.Sleep(3000);

            donorDonatePage.ClickAppointemtTime(time);
         //   Thread.Sleep(3000);

            donorDonatePage.DonorCompleteMatchQuestionnaire();

        }


        public void donorRemoveQueue()
        {
            Thread.Sleep(4000);

            donorDonatePage.ClicGoItButton();
           
            donorDonatePage.OutherOptionsScrollDownList();
            donorDonatePage.ClickRemoveQueue();
            donorDonatePage.ClickApproveRemoveQueue();

        }

        public void NavigateToDonorSite()
        {
            donorDonatePage.navigateTodonationPage();
        }

        //gmail flow
        public void VarificationEmailAppointment(string gmailDonorUserName, string gmailDonorPassword,
                  string dateAppointamte)
        {
            //--- gmail verification
            Thread.Sleep(3000);

            donorDonatePage.openGmail();
            donorDonatePage.sendGmailUserName(gmailDonorUserName);
            donorDonatePage.GmailClickNext();

            Thread.Sleep(3000);

            donorDonatePage.sendGmailPassword(gmailDonorPassword);
            donorDonatePage.GmailClickNext();

            Thread.Sleep(2000);
            donorDonatePage.navigateToGmailInbox();
        }
        public bool isEmailAppointmantAccept(string dateAppointmant)
        {
            donorDonatePage.isEmailAppointmantRecive(dateAppointmant);
            return true;
        }

        public bool IsAppointemtTimeDisplay(string time)
        {
            Thread.Sleep(4000);
            donorDonatePage.IsAppointemtTimeDisplay(time);
            return true;
        }




    }

}
