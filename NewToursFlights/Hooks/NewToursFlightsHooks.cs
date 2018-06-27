using NewToursFlights.StepDef;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NewToursFlights.Hooks
{
    [Binding]
    public sealed class NewToursFlightsHooks
    {
        IWebDriver gdriver;
         
        public NewToursFlightsHooks()
        {
            switch (NewToursFlightsSettings.Default.Browser)
            {
                case "Chrome":
                    ChromeDriver Cdriver = new ChromeDriver();
                    gdriver = Cdriver;
                    break;
                case "FireFox":
                    FirefoxDriver Fdriver = new FirefoxDriver();
                    gdriver = Fdriver;
                    break;

            }
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            NewToursFlightsSteps._driver = gdriver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
        }
    }
}
