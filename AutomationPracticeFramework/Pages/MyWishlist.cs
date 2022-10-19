using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class MyWishlist
    {
        readonly IWebDriver driver;
        public By formWishlist = By.Id("mywishlist");
        public By newWishlist = By.Id("name");
        public By submitWishlist = By.Id("submitWishlist");

        public MyWishlist(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(formWishlist));
        }
    }
}
