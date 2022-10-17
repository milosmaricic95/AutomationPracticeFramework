using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        HomePage hp = new HomePage(Driver);
        Utilities ut = new Utilities(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)
        {
            this.productData = productData;
        }

        [Given(@"user opens '(.*)' section")]
        public void GivenUserOpensSection(string cat)
        {
            hp.ReturnCategoryList(cat)[1].Click();
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            PLPPage plp = new PLPPage(Driver);
            ut.ClickOnElement(plp.firstProduct);
        }
        
        [Given(@"increases quantity to '(.*)'")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            PDPPage pdp = new PDPPage(Driver);
            By iframe = By.ClassName("fancybox-iframe");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            //Driver.FindElement(pdp.quantity).Clear();
            ut.ClearInputField(pdp.quantiity);
            ut.EnterTextInElement(pdp.quantiity, qty);
            productData.ProductName = ut.ReturnTextFromElement(pdp.productName);
        }
        
        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            PDPPage pdp = new PDPPage(Driver);
            ut.ClickOnElement(pdp.addButton);
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"cart is opened and product is added to cart")]
        public void ThenCartIsOpenedAndProductIsAddedToCart()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
