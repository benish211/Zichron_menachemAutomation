using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZichronMenachemAutomation.PageObject.RegistarPages
{
    public class DonorRegistarPages
    {
        By EntryButtonBy = By.XPath("//p[@class='style_login_text__nKU2Q']");

        
        [SetUp]
        public void BeforTest()
        {
           

        }
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


}
}
