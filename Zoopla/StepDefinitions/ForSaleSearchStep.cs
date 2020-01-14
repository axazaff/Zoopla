using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Zoopla.StepDefinitions
{
    [Binding]
    public sealed class ForSaleSearchStep
    {
               [Given(@"I navigate to zoopla homepage")]
        public void GivenINavigateToZooplaHomepage()
        {
            
        }
        
        [When(@"I enter a ""(.*)"" in the seach text box")]
        public void WhenIEnterAInTheSeachTextBox(string p0)
        {

        }
        
        [When(@"I select ""(.*)"" from minimum price dropdown")]
        public void WhenISelectFromMinimumPriceDropdown(string p0)
        {
          
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
           
        }
        
        [Then(@"a list of ""(.*)"" in ""(.*)"" are displayed")]
        public void ThenAListOfInAreDisplayed(string p0, string p1)
        {
          
        }
        
        [Then(@"I click on one of the result links")]
        public void ThenIClickOnOneOfTheResultLinks()
        {
           
        }

    }
}
