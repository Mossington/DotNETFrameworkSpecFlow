Feature: HuBooHomePage
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Regression
Scenario: Home Page loads
	Given i have navigated to the HuBoo website
	Then the user is on the HuBoo home page
	"""
	Multi-channel Ecommerce Fulfilment Made Easy
	"""

@Regression
Scenario: Clicking telephone number directs user to the contact us page
	Given i have navigated to the HuBoo website
	When i click the telephone number
	Then i am redirected to the contact us page
	"""
	For sales enquiries please enter your details here.
	"""

@Regression
Scenario: User can input credentials on the Login Page
	Given i have navigated to the HuBoo website
	When i click on the Login button
	And i have naviagted to the Login Page
	"""
	Login to Huboo
	"""
	Then i can input user crednetials

@Regression
Scenario:  Coivid update is displayed on the home page
	Given i have navigated to the HuBoo website
	Then the Covid update is displayedhuboo
	"""
	Coronavirus : We are open as normal
	"""

@Regression
Scenario: Large Letter to 500g displays the correct price for Huboo 24 Hour Standard
	Given a user is on the Huboo Pricing page
	Then the Large Letter to 500g displays the correct price for Huboo 24 Hour Standard