using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class SignInPage
    {
        readonly IWebDriver driver;

        public By emailField = By.Id("email");
        public By passwordField = By.Id("passwd");
        public By signInBtn = By.Id("SubmitLogin");
        public By email = By.Id("email_create");
        public By createAcc = By.Id("SubmitCreate");
        public By authenticationPage = By.Id("authentication");

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(authenticationPage));
        }
    }
}
