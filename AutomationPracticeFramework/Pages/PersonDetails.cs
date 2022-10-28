using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class PersonDetails
    {
        readonly IWebDriver driver;
        public By PersonalDetails = By.ClassName("box");
        public By lastName = By.Id("lastname");
        public By oldPassword = By.Id("old_passwd");
        public By saveBtn = By.Name("submitIdentity");
        public By prsnDtls = By.ClassName("page-subheading");
        public By successMsg = By.ClassName("alert");

        public PersonDetails(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(PersonalDetails));
        }

        public bool SuccessfullyUpdatedDetails(string updateMsg)
        {
            By text = By.ClassName("alert");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(successMsg)).Displayed;
        }
    }


}
