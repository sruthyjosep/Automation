using NewToursFlights.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToursFlights.Pages
{
    class ResultPage
    {
        IWebDriver driver;
        WebDriverWait webDriverWait;
        public readonly By pageHeading = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr[1]/td[2]/table/tbody/tr[3]/td/p/font/b/font[2]");

        public ResultPage(IWebDriver idriver)
        {
            driver = idriver;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
        
        
            public void verifyPageHeadings()
        {
            Assert.AreEqual(PageHeadings.RP_PageHeading, driver.FindElement(pageHeading).Text, "Flight Finder - Flight Details heading mismatch");
            
        }
    }
}
