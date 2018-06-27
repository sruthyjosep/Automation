using NewToursFlights.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewToursFlights.Pages
{
    class HomePage
    {
        IWebDriver driver;
        WebDriverWait webDriverWait;
        public readonly By userName = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input");
        public readonly By passWord = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[3]/td[2]/input");
        public readonly By signInButton = By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[2]/td[3]/form/table/tbody/tr[4]/td/table/tbody/tr[4]/td[2]/div/input");

        public HomePage(IWebDriver idriver)
        {
            driver = idriver;
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void openNewToursWebsite()
        {
            driver.Navigate().GoToUrl(PageHeadings.URL);
            
        }

        public void enterUsername(string username)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(userName)).SendKeys(username);

        }

        public void enterPassword(string password)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(passWord)).SendKeys(password);
        }

        public void clickSignIn()
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(signInButton)).Click();
        }

    }
}
