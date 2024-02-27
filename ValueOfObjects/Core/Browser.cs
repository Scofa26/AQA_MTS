using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Core;
using ValueOfObjects.Helpers.Configuration;

namespace ValueOfObjects.Core
{
    internal class Browser
    {
        public IWebDriver? Driver { get; }

        public Browser()
        {
            Driver = Configurator.BrowserType?.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                "firefox" => new DriverFactory().GetFirefoxDriver(),
                _ => Driver
            };

            Driver?.Manage().Window.Maximize();
            Driver?.Manage().Cookies.DeleteAllCookies();
            // Driver!.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}
