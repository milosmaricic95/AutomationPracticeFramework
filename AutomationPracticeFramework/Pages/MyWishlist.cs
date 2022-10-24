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

        public bool MyWishlistIsDisplayed(string title)
        {
            By link = By.XPath("//td//a[contains(text(),'" + title + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(link)).Displayed;
        }
    }
}
