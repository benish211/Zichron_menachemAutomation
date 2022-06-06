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
    public class DonorRegistarPages
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
        public DonorRegistarPages(IWebDriver driver)
        {
            _driver = driver;
            { }
        }
    
        public void ClickEntryButton()
    {
        _driver.FindElement(EntryButtonBy).Click();

    }
        public void ClickRegistarButton()
        {
            _driver.FindElement(RegistryButtonBy).Click();
        }

        //input user data
        public void SendDonorEmail(string donorEmail)
        {
            _driver.FindElement(RegistarEmailFeildBy).SendKeys(donorEmail);

        }
        public void SendDonorPassword(string donorPassword)
        {
            _driver.FindElement(RegPasswordFeildBy).SendKeys(donorPassword);
        }
        public void ClickRegistarDonorButton()
        {
            _driver.FindElement(ReggistarButtonBy).Click();
        }
        //user personal details
        public void SendDonorName(string donorName)
        {         
 
            _driver.FindElement(RegistarFieldNameBy).SendKeys(donorName);
        }
        public void SendDonorFamily(string donorFamily)
        {
            _driver.FindElement(RegistarFieldFamilyBy).SendKeys(donorFamily);
        }
        public void SendDonorPhoneNumber(string donorPhoneNumber)
        {
            _driver.FindElement(RegistarFieldPhoneBy).SendKeys(donorPhoneNumber);
        }
        public void ClickBlodType()
        {
            _driver.FindElement(BlodTypeOBy).Click();
        }
        public void ClickRegistarDonorCompleteButton()
        {
            _driver.FindElement(ReggistarCompleteButtonBy).Click();
        }
    }
}
