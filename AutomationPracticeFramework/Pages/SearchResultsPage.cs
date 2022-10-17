using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class SearchResultPage
    {
        readonly IWebDriver driver;

        public By searchResult = By.ClassName("lighter");
        private By searchPage = By.Id("search");

        public SearchResultPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(searchPage));
        }
    }
}
