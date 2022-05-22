using InfrastructureAutomationLogin.PageObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZichronMenachemAutomation.PageObject.RegistarPages;

namespace ZichronMenachemAutomation.Flows
{
    public class DonorFlow
    {
        IWebDriver _driver;
        DonorRegistarPages donorRegistarPages;

        public DonorFlow(IWebDriver driver)
        {
            _driver = driver;
            donorRegistarPages = new DonorRegistarPages(_driver);
        }

        public void RegistarDonorFlow()
        {
            donorRegistarPages.ClickEntryButton();

            Thread.Sleep(5000);
        }
    }
}
