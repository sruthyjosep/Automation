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
    class FlightFinderPage
    {
        IWebDriver driver;
        WebDriverWait webDriverWait;

        public readonly By flightDetailsHeading = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[1]/td/font/font/b/font/font");
        public readonly By preferencesHeading = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/font/font/b/font/font");
        public readonly By roundTrip = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[1]");
        public readonly By oneWayTrip = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]");
        public readonly By noofPass = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select");
        public readonly By departfrom = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/select");
        public readonly By departmonth = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[1]");
        public readonly By departday = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[2]");
        public readonly By arriveto = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td[2]/select");
        public readonly By arrivemonth = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[1]");
        public readonly By arriveday = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[2]");
        public readonly By businessserviceclass = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/font/font/input[1]");
        public readonly By  firstserviceclass = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/font/font/input[2]");
        public readonly By airline = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/select");
        public readonly By continueButton = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td/input");

        public FlightFinderPage(IWebDriver idriver)
        {
            driver = idriver;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void verifyPageHeadings()
        {
            Assert.AreEqual(PageHeadings.FF_FlightDetails, driver.FindElement(flightDetailsHeading).Text, "Flight Finder - Flight Details heading mismatch");
            Assert.AreEqual(PageHeadings.FF_Preferences, driver.FindElement(preferencesHeading).Text, "Flight Finder - Preferences heading mismatch");
        }

        public void selectTripType()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(roundTrip)).Click();
            
        }

        public void selectPassengerNumber(string pno)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(noofPass));
            var selectElement = new SelectElement(driver.FindElement(noofPass));
            selectElement.SelectByText(pno);
        }

        public void selectDepartFrom(string depature)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(departfrom));
            var selectElement = new SelectElement(driver.FindElement(departfrom));
            selectElement.SelectByValue(depature);
        }

        public void selectDepartMonth(string depaturemonth)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(departmonth));
            var selectElement = new SelectElement(driver.FindElement(departmonth));
            selectElement.SelectByValue(depaturemonth);
        }

        public void selectDepartDay(string dday)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(departday));
            var selectElement = new SelectElement(driver.FindElement(departday));
            selectElement.SelectByValue(dday);
        }

        public void selectArriveTo(string arrival)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(arriveto));
            var selectElement = new SelectElement(driver.FindElement(arriveto));
            selectElement.SelectByText(arrival);
        }

        public void selectReturnMonth(string rmonth)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(arrivemonth));
            var selectElement = new SelectElement(driver.FindElement(arrivemonth));
            selectElement.SelectByValue(rmonth);
        }

        public void selectReturnDay(string rday)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(arriveday));
            var selectElement = new SelectElement(driver.FindElement(arriveday));
            selectElement.SelectByValue(rday);
        }

        public void selectFirstClass()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(firstserviceclass)).Click();

        }

        public void selectAirline(string pairline)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(airline));
            var selectElement = new SelectElement(driver.FindElement(airline));
            selectElement.SelectByText(pairline);
        }

        public void clickContinue()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(continueButton)).Click();
        }

    }
}
