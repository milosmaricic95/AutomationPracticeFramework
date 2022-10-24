Feature: MyAccount
		As a user 
	I want to be able to click on the Sign in link
	So i Can login to my account

@mytag
Scenario: The user can log in to his account
		Given Clicks on the Sign in link
		And Fill in the Email address with 'milos.maricic.95@gmail.com' and Password 'milos123'
		When Click on the Sign in button
		Then message 'Welcome to your account. Here you can manage all of your personal information and orders.' is displayed to the user

Scenario: User can create an account
		Given Clicks on the Sign in link
		And initiates a flow for creating an account
		And user enters all required personal details
		When submits the sign up form
		Then user will be logged in 
		And user's full name is displayed

Scenario: User can create new wishlist
		Given Clicks on the Sign in link
		And Fill in the Email address with 'milos.maricic.95@gmail.com' and Password 'milos123'
		When Click on the Sign in button
		And click on mywishlist
		Then type in new wishlist
		And click save