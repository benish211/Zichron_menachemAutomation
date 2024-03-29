﻿using InfrastructureAutomationLogin.BaseData;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZichronMenachemAutomation.PageObject.DonorPages
{
    public class DonorDonatePage : BasePage
    {
        By WelcomeDonorBy = By.XPath("//div[@class='BookDonationScreen_name__8C88e']");
        By RegistrationDonorSuccessBy = By.XPath("//div[@class='BookDonationScreen_welcomeText__wDNC-']");
        By DonorCompleteMatchquestionnaireBy = By.XPath("//div[@class='Button_buttonText__7LKwV']");
        By ButtoneRemoveQueueBy = By.XPath("//img[@alt='Cancel']");
        By ButtoneApproveRemoveQueueBy = By.XPath("//div[contains(text(),'כן, בטלו לי את התור')]");
        By HamburgerTabBy = By.XPath("//*[name()='path' and contains(@d,'M3 18h18v-')]");
        By LogoutButtonBy = By.XPath("//span[contains(text(),'התנתקות')]");
        By GotItButtonBy = By.XPath("//div[contains(text(),'הבנתי')]");
        By OutherOptionsListBy = By.XPath("//h6[contains(text(),'פעולות נוספות')]");




        //Gmail
        By GmailInputUserNameBy = By.XPath("//input[@id='identifierId']");
        By GmailClickNextButtonBy = By.XPath("//span[contains(text(),'Next')]");
        By GmailInputPasswordBy = By.XPath("//input[@name='Passwd']");
      


        IWebDriver _driver;
        public DonorDonatePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            { }
        }

        public void RegistrationDonorSuccess()
        {
            waitForElementVisibility(RegistrationDonorSuccessBy);
        }

        public void ClickAppointemtTime(string time)

        {

            _driver.FindElement(By.XPath($"(//div[@class='Picker_pickerButton__CuvZS'][normalize-space()='{time}'])[1]")).Click();
        }

        public bool IsAppointemtTimeDisplay(string time)

        {
            _driver.FindElement(By.XPath($"(//div[contains(text(),'{time}')])"));
            return true;
        }

        public void DonorCompleteMatchQuestionnaire()
        {
            click(DonorCompleteMatchquestionnaireBy);
        }


        public void ClickRemoveQueue()
        {
            _driver.FindElement(ButtoneRemoveQueueBy).Click();
        }
        public void ClickApproveRemoveQueue()
        {
            _driver.FindElement(ButtoneApproveRemoveQueueBy).Click();
        }

        public void ClickHamburgerTab()
        {
            _driver.FindElement(HamburgerTabBy).Click();

        }
        public void ClicLogoutButton()
        {
            _driver.FindElement(LogoutButtonBy).Click();

        }

        public void OutherOptionsScrollDownList()
        {
            _driver.FindElement(OutherOptionsListBy).Click();

        }

        //What spontaneity popup
        public void ClicGoItButton()
        {
           if ((_driver.FindElement(GotItButtonBy).Displayed))
            {
                _driver.FindElement(GotItButtonBy).Click();
            }
           else
            {
                Console.WriteLine("not found");

            }

        }

        public void navigateTodonationPage()
        {
            _driver.Navigate().GoToUrl("https://zm-donor-qa.web.app/donation");
        }



        //gamil locators
        public void openGmail()
        {
            _driver.Navigate().GoToUrl("https://accounts.google.com/");
        }
        public void sendGmailUserName(string gmailDonorUserName)
        {
            _driver.FindElement(GmailInputUserNameBy).SendKeys(gmailDonorUserName);

        }
        public void GmailClickNext()
        {
            _driver.FindElement(GmailClickNextButtonBy).Click();
        }
        public void sendGmailPassword(string gmailDonorPassword)
        {
            fillText(GmailInputPasswordBy, gmailDonorPassword);
        }
        public void navigateToGmailInbox()
        {
            _driver.Navigate().GoToUrl("https://mail.google.com/mail/");
        }
        public bool isEmailAppointmantRecive(string dateAppointamte)
        {
            _driver.FindElement(By.XPath($"//span[contains(text(),'הרשמתך לתור לתרומת טרומבוציטים בתאריך {dateAppointamte}')]"));
            return true;
        }



    }
}
