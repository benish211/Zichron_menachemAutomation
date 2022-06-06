using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZichronMenachemAutomation.PageObject.DonorPages
{
    public class DonorDonatePage
    {
        By WelcomeDonorBy = By.XPath("//div[@class='BookDonationScreen_name__8C88e']");
        By RegistrationDonorSuccessBy = By.XPath("//div[@class='BookDonationScreen_welcomeText__wDNC-']");
        By DonorCompleteMatchquestionnaireBy = By.XPath("//div[@class='Button_buttonText__7LKwV']");
        By ButtoneRemoveQueueBy = By.XPath("//div[@class='UpcomingDonationScreen_cancelButton__KvXzP']");
        By ButtoneApproveRemoveQueueBy = By.XPath("//div[@class='Button_buttonText__7LKwV']");
        By HamburgerTabBy = By.XPath("//*[name()='path' and contains(@d,'M3 18h18v-')]");
        By LogoutButtonBy = By.XPath("//span[contains(text(),'התנתקות')]");



        //Gmail
        By GmailInputUserNameBy = By.XPath("//input[@id='identifierId']");
        By GmailClickNextButtonBy = By.XPath("//span[contains(text(),'Weiter')]");
        By GmailInputPasswordBy = By.XPath("//input[@name='password']");
      


        IWebDriver _driver;
        public DonorDonatePage(IWebDriver driver)
        {
            _driver = driver;
            { }
        }

        public void RegistrationDonorSuccess()
        {
            _driver.FindElement(RegistrationDonorSuccessBy);
        }

        public void ClickAppointemtTime(string time)
        {
            _driver.FindElement(By.XPath($"(//div[@class='Picker_pickerButton__CuvZS'][normalize-space()='{time}'])[1]")).Click();
        }

        public void DonorCompleteMatchQuestionnaire()
        {
            _driver.FindElement(DonorCompleteMatchquestionnaireBy).Click();
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
            _driver.FindElement(GmailInputPasswordBy).SendKeys(gmailDonorPassword);
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
