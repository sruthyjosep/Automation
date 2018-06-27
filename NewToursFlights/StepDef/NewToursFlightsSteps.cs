using Newtonsoft.Json;
using NewToursFlights.DataModel;
using NewToursFlights.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using TechTalk.SpecFlow;

namespace NewToursFlights.StepDef
{
    [Binding]
    public class NewToursFlightsSteps
    {
        public static IWebDriver _driver;
        HomePage objHomePage;
        FlightFinderPage objFlightFinderPage;
        PaymentDetailsPage objPaymentDetailsPage;
        List<UserCredentials> objUserCredentials;
        List<FlightFinder> objFlightFinder;
        List<PaymentDetails> objPaymentDetails;
        FlightTimePage objFlightTime;
        ResultPage objResultPage;

        public NewToursFlightsSteps()
        {
            objHomePage = new HomePage(_driver);
            objFlightFinderPage = new FlightFinderPage(_driver);
            objFlightTime = new FlightTimePage(_driver);
            objPaymentDetailsPage = new PaymentDetailsPage(_driver);
            var jsonUCString = File.ReadAllText(@"c:\users\sjoseprasad\source\repos\NewToursFlights\NewToursFlights\DataModel\usercredentials.json");  //for this always keep a copy of Json Handler file in ur project directory
            objUserCredentials = JsonConvert.DeserializeObject<List<UserCredentials>>(jsonUCString);
            var jsonFFString = File.ReadAllText(@"c:\users\sjoseprasad\source\repos\NewToursFlights\NewToursFlights\DataModel\FlightFinder.json");  //for this always keep a copy of Json Handler file in ur project directory
            objFlightFinder = JsonConvert.DeserializeObject<List<FlightFinder>>(jsonFFString);
            var jsonPDString = File.ReadAllText(@"c:\users\sjoseprasad\source\repos\NewToursFlights\NewToursFlights\DataModel\PaymentDetails.json");  //for this always keep a copy of Json Handler file in ur project directory
            objPaymentDetails = JsonConvert.DeserializeObject<List<PaymentDetails>>(jsonPDString);
        }

        [Given(@"I open Newtours website")]
        public void GivenIOpenNewtoursWebsite()
        {

            objHomePage.openNewToursWebsite();
        }
        
        [Given(@"I enter the user")]
        public void GivenIEnterTheUser()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours") || ScenarioContext.Current.ScenarioInfo.Title.Contains("Business class flight booking of a registered user of Newtours")) 
             objHomePage.enterUsername(objUserCredentials[0].username); 
           



        }
        
        [Given(@"I enter the password")]
        public void GivenIEnterThePassword()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours") || ScenarioContext.Current.ScenarioInfo.Title.Contains("Business class flight booking of a registered user of Newtours"))
                objHomePage.enterPassword(objUserCredentials[0].password);
          }
        
        [Given(@"click the Signin button")]
        public void GivenClickTheSigninButton()
        {
            objHomePage.clickSignIn();
        }
        
        [Given(@"I select the trip type")]
        public void GivenISelectTheTripType()
        {
            objFlightFinderPage.selectTripType();
        }
        
        [Given(@"I select the number of passengers")]
        public void GivenISelectTheNumberOfPassengers()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objFlightFinderPage.selectPassengerNumber(objFlightFinder[0].noofpass);
            else
                objFlightFinderPage.selectPassengerNumber(objFlightFinder[1].noofpass);
        }
        
        [Given(@"I select the depature location")]
        public void GivenISelectTheDepatureLocation()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objFlightFinderPage.selectDepartFrom(objFlightFinder[0].departingfrom);
            else
                objFlightFinderPage.selectDepartFrom(objFlightFinder[0].departingfrom);
        }
        
        [Given(@"I select the date of depature")]
        public void GivenISelectTheDateOfDepature()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
            {
                objFlightFinderPage.selectDepartMonth(objFlightFinder[0].departuredateMonth);
                objFlightFinderPage.selectDepartDay(objFlightFinder[0].departuredateDay);
            }
            else
            {
                objFlightFinderPage.selectDepartMonth(objFlightFinder[1].departuredateMonth);
                objFlightFinderPage.selectDepartDay(objFlightFinder[1].departuredateDay);
            }
        }
        
        [Given(@"I select the arrival location")]
        public void GivenISelectTheArrivalLocation()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
            {
                objFlightFinderPage.selectArriveTo(objFlightFinder[0].arrivingto);
            }
            else
                objFlightFinderPage.selectArriveTo(objFlightFinder[1].arrivingto);


        }

        [Given(@"I select the return date")]
        public void GivenISelectTheReturnDate()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objFlightFinderPage.selectReturnMonth(objFlightFinder[0].returndateMonth);
           else
                objFlightFinderPage.selectReturnDay(objFlightFinder[1].returndateDay);
        }
        
        [Given(@"I select the service class")]
        public void GivenISelectTheServiceClass()
        {
            objFlightFinderPage.selectFirstClass();
        }
        
        [Given(@"I select the airline")]
        public void GivenISelectTheAirline()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objFlightFinderPage.selectAirline(objFlightFinder[0].airline);
            else
                objFlightFinderPage.selectAirline(objFlightFinder[1].airline);
        }
        
        [Given(@"I click continue")]
        public void GivenIClickContinue()
        {
            objFlightFinderPage.clickContinue();
        }
        
        [Given(@"I select the time of initial flight")]
        public void GivenISelectTheTimeOfInitialFlight()
        {
            objFlightTime.selectDepatureTime();
        }
        
        [Given(@"I select the time of return flight")]
        public void GivenISelectTheTimeOfReturnFlight()
        {
            objFlightTime.selectReturnTime();
        }

        [Given(@"I click continue in flight time")]
        public void GivenIClickContinueInFlightTime()
        {
            objFlightTime.clickContinueButton();
        }
        [Given(@"I enter the First Name of pass one")]
        public void GivenIEnterTheFirstNameOfPassOne()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterPass1FName(objPaymentDetails[0].pass1fname);
            else
                objPaymentDetailsPage.enterPass1FName(objPaymentDetails[1].pass1fname);
        }
        [Given(@"I enter the Last nameof pass one")]
        public void GivenIEnterTheLastNameofPassOne()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterPass1LName(objPaymentDetails[0].pass1lname);
            else
                objPaymentDetailsPage.enterPass1LName(objPaymentDetails[1].pass1lname);
        }
        [Given(@"I enter the First name of pass two")]
        public void GivenIEnterTheFirstNameOfPassTwo()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterPass2FName(objPaymentDetails[0].pass2fname);
            
        }
        [Given(@"I enter the Last name of pass two")]
        public void GivenIEnterTheLastNameOfPassTwo()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterPass2LName(objPaymentDetails[0].pass2fname);
             
        }


        [Given(@"I select the card type for payment")]
        public void GivenISelectTheCardTypeForPayment()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterCardType(objPaymentDetails[0].cardtype);
            else
                objPaymentDetailsPage.enterCardType(objPaymentDetails[1].cardtype);
        }
        
        [Given(@"I enter the card numnber")]
        public void GivenIEnterTheCardNumnber()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterCardNo(objPaymentDetails[0].cardnumber);
            else
                objPaymentDetailsPage.enterCardNo(objPaymentDetails[1].cardnumber);
        }

        [Given(@"I enter the expiry month")]
        public void GivenIEnterTheExpiryMonth()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterExpiryMonth(objPaymentDetails[0].expirymonth);
            else
                objPaymentDetailsPage.enterExpiryMonth(objPaymentDetails[1].expirymonth);
        }

        [Given(@"I enter the expiry day")]
        public void GivenIEnterTheExpiryDay()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterExpiryYear(objPaymentDetails[0].expiryyear);
            else
                objPaymentDetailsPage.enterExpiryYear(objPaymentDetails[1].expiryyear);
        }


        [Given(@"to enter Billing address, I enter the address")]
        public void GivenToEnterBillingAddressIEnterTheAddress()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterAddress(objPaymentDetails[0].address);
            else
                objPaymentDetailsPage.enterAddress(objPaymentDetails[1].address);
        }
        
        [Given(@"I enter the city")]
        public void GivenIEnterTheCity()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterCity(objPaymentDetails[0].city);
            else
                objPaymentDetailsPage.enterCity(objPaymentDetails[1].city);
        }
        
        [Given(@"I enter the province")]
        public void GivenIEnterTheProvince()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterState(objPaymentDetails[0].state);
            else
                objPaymentDetailsPage.enterState(objPaymentDetails[1].state);
        }
        
        
        [Given(@"I enter the country")]
        public void GivenIEnterTheCountry()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("First class flight booking of a registered user of Newtours"))
                objPaymentDetailsPage.enterCountry(objPaymentDetails[0].country);
            else
                objPaymentDetailsPage.enterCountry(objPaymentDetails[1].country);
        }
      
        
        [Given(@"I click secure purchase")]
        public void GivenIClickSecurePurchase()
        {
                objPaymentDetailsPage.clicksecurePayment();
            
        }
        
        [Then(@"I should be able to see the flight booking page")]
        public void ThenIShouldBeAbleToSeeTheFlightBookingPage()
        {
            objFlightFinderPage.verifyPageHeadings();
        }
        
        [Then(@"I should see the time slots avaliable for the selected flight")]
        public void ThenIShouldSeeTheTimeSlotsAvaliableForTheSelectedFlight()
        {
            objFlightTime.verifyPageHeadings();
        }
        
        [Then(@"I should see the payment details for the selected flight")]
        public void ThenIShouldSeeThePaymentDetailsForTheSelectedFlight()
        {
            objPaymentDetailsPage.verifyPageHeading();
        }
        
        [Then(@"I should get the booking confirmation")]
        public void ThenIShouldGetTheBookingConfirmation()
        {
            objResultPage.verifyPageHeadings();
        }
    }
}
