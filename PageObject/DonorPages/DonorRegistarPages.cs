using InfrastructureAutomationLogin.BaseData;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZichronMenachemAutomation.PageObject.RegistarPages
{
    public class DonorRegistarPages : BasePage
    {
        By EntryButtonBy = By.XPath("//p[@class='style_login_text__nKU2Q']");
        By RegistryButtonBy = By.XPath("//div[@class='SignInScreen_alternativeButton__qUz7F Button_textButton__2L3VZ']");


        ////label[contains(text(),'סיסמה')]
        ////div[contains(text(),'הירשם')]
        
        By RegistarEmailFeildBy = By.XPath("/html/body/div/div/div/div[2]/div[1]/div[2]/div/div/input");
        By RegPasswordFeildBy = By.XPath("/html/body/div/div/div/div[2]/div[1]/div[3]/div/div/input");
        By ReggistarButtonBy = By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[4]");


        By RegistarFieldNameBy = By.XPath("/html/body/div/div/div/div[2]/div[3]/div/div/input");
        By RegistarFieldFamilyBy = By.XPath("/html/body/div/div/div/div[2]/div[4]/div/div/input");
        By RegistarFieldPhoneBy = By.XPath("/html/body/div/div/div/div[2]/div[5]/div/div/input");
        By BlodTypeOBy = By.XPath("//div[contains(text(),'O-')]");
        By ReggistarCompleteButtonBy = By.XPath("//body/div[@id='root']/div[1]/div[1]/div[2]/div[8]");




        OpenQA.Selenium.IWebDriver _driver;
        public DonorRegistarPages(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            { }
        }

        public void ClickEntryButton()
    {

            click(EntryButtonBy);

    }
        public void ClickRegistarButton()
        {
            click(RegistryButtonBy);
        }

        //input user data
        public void SendDonorEmail(string donorEmail)
        {
            fillText(RegistarEmailFeildBy, donorEmail);
            

        }
        public void SendDonorPassword(string donorPassword)
        {
            fillText(RegPasswordFeildBy, donorPassword);

        }
        public void ClickRegistarDonorButton()
        {
            click(ReggistarButtonBy);
        }
        //user personal details
        public void SendDonorName(string donorName)
        {         
 
            fillText(RegistarFieldNameBy,donorName);
        }
        public void SendDonorFamily(string donorFamily)
        {
            fillText(RegistarFieldFamilyBy, donorFamily);

        }
        public void SendDonorPhoneNumber(string donorPhoneNumber)
        {
            fillText(RegistarFieldPhoneBy, donorPhoneNumber);

        }
        public void ClickBlodType()
        {
            click(BlodTypeOBy);
        }
        public void ClickRegistarDonorCompleteButton()
        {
            click(ReggistarCompleteButtonBy);
        }
    }
}
