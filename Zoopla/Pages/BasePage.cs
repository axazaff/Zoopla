using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Zoopla.Commons;

namespace Zoopla.Pages
{
    public class BasePage : Driver
    {
        public string Base_URL = "http://www.zoopla.co.uk/";
        public SelectElement select;

        public void LaunchURL()
        {
            _driver.Navigate().GoToUrl(Base_URL);

        }
        public void SelectByText(IWebElement element, string text)
        {
            select = new SelectElement(element);
            select.SelectByText(text);
        }
        public void SelectByValue(IWebElement element, string value)
        {
            select = new SelectElement(element);
            select.SelectByValue(value);
        }
        public void SelectByIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);

        }
    }
}
