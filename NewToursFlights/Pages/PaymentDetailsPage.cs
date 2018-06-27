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
    class PaymentDetailsPage
    {
        IWebDriver driver;
        WebDriverWait webDriverWait;
        public readonly By departureHeading = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td/table/tbody/tr[1]/td[1]/b/font");
        public readonly By arrivalHeading = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td/table/tbody/tr[4]/td[1]/b/font");
        public readonly By departureCost = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td/table/tbody/tr[3]/td[3]/font");
        public readonly By arrivalCost = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td/table/tbody/tr[6]/td[3]/font");
        public readonly By p1fname = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[1]/input");
        public readonly By p1lname = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input");
        public readonly By p2fname = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[1]/input");
        public readonly By p2lname = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/input");
        public readonly By cardtype = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td/table/tbody/tr[2]/td[1]/select");
        public readonly By cardno = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td/table/tbody/tr[2]/td[2]/input");
        public readonly By emonth = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td/table/tbody/tr[2]/td[3]/select[1]");
        public readonly By eyear = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td/table/tbody/tr[2]/td[3]/select[2]");
        public readonly By address = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/input");
        public readonly By city = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/input");
        public readonly By state = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input[1]");
        public readonly By country = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/select");
        public readonly By clickSecurePayment = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[24]/td/input");

        public PaymentDetailsPage(IWebDriver idriver)
        {
            driver = idriver;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void verifyPageHeading()
        {
            Assert.AreEqual(PageHeadings.FT_Depart, driver.FindElement(departureHeading).Text, "Data mismatch");
            Assert.AreEqual(PageHeadings.FT_Arrive, driver.FindElement(arrivalHeading).Text, "Data mismatch");
            Assert.AreEqual(PageHeadings.PD_dcost, driver.FindElement(departureCost).Text, "Data mismatch");
            Assert.AreEqual(PageHeadings.PD_acost, driver.FindElement(arrivalCost).Text, "Data mismatch");
        }

        public void enterPass1FName(string fname)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(p1fname)).SendKeys(fname);

        }


        public void enterPass1LName(string lname)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(p1lname)).SendKeys(lname);
        }

        public void enterPass2FName(string fname)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(p2fname)).SendKeys(fname);
        }


        public void enterPass2LName(string lname)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(p2lname)).SendKeys(lname);
        }

        public void enterCardType(string ctype)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(cardtype));
            var selectElement = new SelectElement(driver.FindElement(cardtype));
            selectElement.SelectByText(ctype);
        }

        public void enterCardNo(string cno )
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(cardno)).SendKeys(cno);
        }
        public void enterExpiryMonth(string month)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(emonth));
            var selectElement = new SelectElement(driver.FindElement(emonth));
            selectElement.SelectByText(month);
        }
        public void enterExpiryYear(string year)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(eyear));
            var selectElement = new SelectElement(driver.FindElement(eyear));
            selectElement.SelectByText(year);
        }
        public void enterAddress(string paddress)
        {
            driver.FindElement(address).Clear();
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(address)).SendKeys(paddress);
        }
        public void enterCity(string pcity)
        {
            driver.FindElement(city).Clear();
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(city)).SendKeys(pcity);

        }
        public void enterState(string pstate)
        {
            driver.FindElement(state).Clear();
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(state)).SendKeys(pstate);
        }
        public void enterCountry(string pcountry)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(country));
            var selectElement = new SelectElement(driver.FindElement(country));
            selectElement.SelectByText(pcountry);

        }

        public void clicksecurePayment()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(clickSecurePayment)).Click();
        }

    }
}
