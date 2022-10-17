using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class PDPPage
    {
        readonly IWebDriver driver;
        public By pdpDialog = By.Id("product");
        public By quantiity = By.Id("quantity_wanted");
        public By productName = By.XPath("//h1[@itemprop='name']");
        public By addButton = By.Id("add_to_cart");

        public PDPPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pdpDialog));
        }
    }
}
