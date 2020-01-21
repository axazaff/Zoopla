﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Zoopla.Pages
{
    public class ProductDetailsPage : BasePage
    {
        public ProductDetailsPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
    }
}
