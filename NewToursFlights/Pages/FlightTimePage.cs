using NewToursFlights.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace NewToursFlights.Pages
{
    class FlightTimePage
    {
        IWebDriver driver;
        WebDriverWait webDriverWait;
        public readonly By departureHeading = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[1]/tbody/tr[1]/td/table/tbody/tr[2]/td[1]/b/font");
        public readonly By arrivalHeading= By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[2]/tbody/tr[1]/td/table/tbody/tr[2]/td[1]/b/font");
        public readonly By departureTime = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[1]/tbody/tr[5]/td[1]/input");
        public readonly By returnTime = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[2]/tbody/tr[5]/td[1]/input");
        public readonly By clickContinue = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/p/input");
         

        public FlightTimePage(IWebDriver idriver)
        {
            driver = idriver;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void verifyPageHeadings()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
            {
                Assert.AreEqual(PageHeadings.FT_Depart, driver.FindElement(departureHeading).Text, "Flight Finder - Flight Details heading mismatch");
                Assert.AreEqual(PageHeadings.FT_Arrive, driver.FindElement(arrivalHeading).Text, "Flight Finder - Preferences heading mismatch");
            }
            else
            {
                Assert.AreEqual(PageHeadings.FT_Depart2, driver.FindElement(departureHeading).Text, "Flight Finder - Flight Details heading mismatch");
                Assert.AreEqual(PageHeadings.FT_Arrive2, driver.FindElement(arrivalHeading).Text, "Flight Finder - Preferences heading mismatch");

            }
        }

        public void selectDepatureTime()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(departureTime)).Click();
        }

        public void selectReturnTime()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(returnTime)).Click();
        }
        public void clickContinueButton()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(clickContinue)).Click();
        }
    }
}
