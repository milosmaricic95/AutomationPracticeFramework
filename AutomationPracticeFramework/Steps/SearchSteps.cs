using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string term)
        {
            ut.EnterTextInElement(hp.searchField, term);
        }
        
        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            ut.ClickOnElement(hp.searchBtn);
        }
        
        [Then(@"results for '(.*)' search term are displayed")]
        public void ThenResultsForSearchTermAreDisplayed(string term)
        {
            SearchResultPage srp = new SearchResultPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.searchResult), Does.Contain(term), "Wrong search results are displayed");
        }
    }
}
