using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Zoopla.Pages
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
        [FindsBy(How = How.Id, Using = "search-input-location")]
        private IWebElement searchField;

        public void EnterLocation(String location)
        {
            searchField.Clear();
            searchField.SendKeys(location);

        }
    }
}
