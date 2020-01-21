using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Zoopla.Commons
{
    public class Browser: Driver
    {
        private IWebDriver InitChromeDriver()
        {
            new WebDriverManager
                .DriverManager()

                .SetUpDriver(new ChromeConfig());
                return new ChromeDriver();
        }

        private IWebDriver InitChromeHeadless()
        {
            new WebDriverManager

                .DriverManager()
                .SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-gpu", "--Headless");
            return new ChromeDriver(options);
        }

        public void LaunchBrowser(string browser) // WHEN WE WANT TO CHOOSE THE BROSWER THEN WE WRITE STRING
        {
            switch (browser)
            {
                case "Chrome":
                    _driver = InitChromeDriver();
                    break;
                case "Headless":
                    _driver = InitChromeHeadless();
                    break;
                default:
                    _driver = InitChromeHeadless();
                    break;
            }
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait
                = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
        }

        public void CloseBrower()
        {
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Quit();

        }
    }
   

}

