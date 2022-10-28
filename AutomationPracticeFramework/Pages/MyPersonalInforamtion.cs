using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class MyPersonalInforamtion
    {
        readonly IWebDriver driver;
        public By MyPersonalInformation = By.XPath("//*[@class='col-xs-12 col-sm-6 col-lg-4']//*[@title='Information']");
        public By PersonalDetails = By.ClassName("box");
        public By lastName = By.Id("lastname");

        public MyPersonalInforamtion(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(MyPersonalInformation));
        }
    }
}
