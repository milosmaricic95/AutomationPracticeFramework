using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        private readonly PersonData personData;
        public MyAccountSteps(PersonData personData)
        {
            this.personData = personData;
        }

        [Given(@"Clicks on the Sign in link")]
        public void GivenClicksOnTheSignInLink()
        {
            ut.ClickOnElement(hp.signInlink);
        }
        
        [Given(@"Fill in the Email address with '(.*)' and Password '(.*)'")]
        public void GivenFillInTheEmailAddressWithAndPassword(string email, string password)
        {
            SignInPage sinp = new SignInPage(Driver);
            ut.EnterTextInElement(sinp.emailField, email);
            ut.EnterTextInElement(sinp.passwordField, password);
        }
        
        [When(@"Click on the Sign in button")]
        public void WhenClickOnTheSignInButton()
        {
            SignInPage sinp = new SignInPage(Driver);
            ut.ClickOnElement(sinp.signInBtn);
        }

        [Then(@"message '(.*)' is displayed to the user")]
        public void ThenMessageIsDisplayedToTheUser(string successMessage)
        {
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.That(ut.ReturnTextFromElement(map.successfulLogin), Is.EqualTo(successMessage), "The user could not log in");
        }

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            SignInPage sinp = new SignInPage(Driver);
            personData.GeneratedEmail = ut.GenerateRandomEmail();
            ut.EnterTextInElement(sinp.email, personData.GeneratedEmail);
            ut.ClickOnElement(sinp.createAcc);
        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTextInElement(sup.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sup.lastName, TestConstants.LastName);
            personData.FullName = TestConstants.FirstName + " " + TestConstants.LastName;
            ut.EnterTextInElement(sup.password, TestConstants.Password);
            ut.EnterTextInElement(sup.address, TestConstants.Address);
            ut.EnterTextInElement(sup.city, TestConstants.City);
            ut.DropdownSelect(sup.state, TestConstants.State);
            ut.EnterTextInElement(sup.zipCode, TestConstants.ZipCode);
            ut.EnterTextInElement(sup.phone, TestConstants.MobilePhone);
        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerBtn);
        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccountPage map = new MyAccountPage(Driver);
            
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            Assert.True(ut.TextPresentInElement(personData.FullName).Displayed, "User's full name is not displayed");
        }

        [When(@"click on mywishlist")]
        public void WhenClickOn()
        {
            MyAccountPage map = new MyAccountPage(Driver);
            ut.ClickOnElement(map.myWishlist);

        }

        [Then(@"type in new wishlist")]
        public void ThenTypeInNewWishlist()
        {
            MyWishlist mw = new MyWishlist(Driver);
            ut.EnterTextInElement(mw.newWishlist, ut.GenerateRandomString());
     
        }

        [Then(@"click save")]
        public void ThenClickSave()
        {
            MyWishlist mw = new MyWishlist(Driver);
            ut.ClickOnElement(mw.submitWishlist);
        }

        [When(@"Click on my personal information")]
        public void WhenClickOnMyPersonalInformation()
        {
            MyPersonalInforamtion mpi = new MyPersonalInforamtion(Driver);
            ut.ClickOnElement(mpi.MyPersonalInformation);
        }

        [Then(@"update last name section")]
        public void ThenUpdateLastNameSection()
        {
            PersonDetails pd = new PersonDetails(Driver);
            ut.ClearInputField(pd.lastName);
            ut.EnterTextInElement(pd.lastName, TestConstants.LastName);
            ut.EnterTextInElement(pd.oldPassword, PersonData.Password);
        }

        [Then(@"click save button")]
        public void ThenClickSaveButton()
        {
            PersonDetails pd = new PersonDetails(Driver);
            ut.ClickOnElement(pd.saveBtn);
        }


        [Then(@"message '(.*)' is shown to the user")]
        public void ThenMessageIsShownToTheUser(string updateMsg)
        {
            PersonDetails pd = new PersonDetails(Driver);
            Assert.True(pd.SuccessfullyUpdatedDetails(updateMsg), "User could not update personal info");
        }

    }
}

