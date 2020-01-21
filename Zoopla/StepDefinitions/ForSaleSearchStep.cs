using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Zoopla.Pages;

namespace Zoopla.StepDefinitions
{
    [Binding]
    public sealed class ForSaleSearchStep : BasePage
    {
        HomePage homePage = new HomePage(_driver);
        SearchResultPage searchResultPage = new SearchResultPage(_driver);
        ProductDetailsPage productDetailsPage = new ProductDetailsPage(_driver);


       [Given(@"I navigate to zoopla homepage")]
        public void GivenINavigateToZooplaHomepage()
        {
            LaunchURL();
        }
        
        [When(@"I enter a ""(.*)"" in the search text box")]
        public void WhenIEnterAInTheSeachTextBox(string location)
        {
            homePage.EnterLocation(location);
        }
        
        [When(@"I select ""(.*)"" from minimum price dropdown")]
        public void WhenISelectFromMinimumPriceDropdown(string minPrice)
        {
            homePage.SelectMinimumPrice(minPrice);
        }
        
        [When(@"I select ""(.*)"" from maximum price dropdown")]
        public void WhenISelectFromMaximumPriceDropdown(string p0)
        {
           
        }
        
        [When(@"I select ""(.*)"" from property type dropdown")]
        public void WhenISelectFromPropertyTypeDropdown(string p0)
        {
           
        }
        
        [When(@"I select ""(.*)"" from Bedrooms dropdown")]
        public void WhenISelectFromBedroomsDropdown(Decimal p0)
        {
          
        }
        
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            searchResultPage = homePage.ClickOnSearchButton();
        }
        
        [Then(@"a list of ""(.*)"" in ""(.*)"" are displayed")]
        public void ThenAListOfInAreDisplayed(string property, string location)
        {
            searchResultPage.IsPageTitleDisplayedCorrectly(property, location);
            searchResultPage.IsResultDisplayed();

        }
        
        [Then(@"I click on one of the result links")]
        public void ThenIClickOnOneOfTheResultLinks()
        {
            productDetailsPage = searchResultPage.ClickOnAnyResult();
        }

    }
}
