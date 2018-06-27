Feature: NewToursFlights
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
	
@mytag
Scenario: First class flight booking of a registered user of Newtours
	Given I open Newtours website
	And I enter the user
	And I enter the password
	And click the Signin button
	Then I should be able to see the flight booking page
	Given  I select the trip type
	And  I select the number of passengers
	And  I select the depature location
	And  I select the date of depature
	And  I select the arrival location 
	And I select the return date
	And I select the service class
	And I select the airline
	And I click continue
	Then I should see the time slots avaliable for the selected flight
	Given I select the time of initial flight
	And I select the time of return flight
	And I click continue in flight time
	Then I should see the payment details for the selected flight
	Given I enter the First Name of pass one
	And I enter the Last nameof pass one
	And I enter the First name of pass two
	And I enter the Last name of pass two
	And I select the card type for payment
	And I enter the card numnber
	And I enter the expiry month
	And I enter the expiry day
	And to enter Billing address, I enter the address
	And I enter the city
	And I enter the province
	And I enter the country
	And I click secure purchase
	Then I should get the booking confirmation

	Scenario: Business class flight booking of a registered user of Newtours
	Given I open Newtours website
	And I enter the user
	And I enter the password
	And click the Signin button
	Then I should be able to see the flight booking page
	Given  I select the trip type
	And  I select the number of passengers
	And  I select the depature location
	And  I select the date of depature
	And  I select the arrival location 
	And I select the return date
	And I select the service class
	And I select the airline
	And I click continue
	Then I should see the time slots avaliable for the selected flight
	Given I select the time of initial flight
	And I select the time of return flight
	And I click continue in flight time
	Then I should see the payment details for the selected flight
	Given I enter the First Name of pass one
	And I enter the Last nameof pass one
	And I enter the First name of pass two
	And I enter the Last name of pass two
	And I select the card type for payment
	And I enter the card numnber
	And I enter the expiry month
	And I enter the expiry day
	And to enter Billing address, I enter the address
	And I enter the city
	And I enter the province
	And I enter the country
	And I click secure purchase
	Then I should get the booking confirmation

