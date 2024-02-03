using OpenQA.Selenium;
using SeleniumBasic.Utilites.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Core
{
    internal class Browser
    {
        public IWebDriver? Driver { get; }

        public Browser()
        {
            Driver = Configurator.BrowserType?.ToLower() switch
            {
                "chrome" => new DriverFactory().GetChromeDriver(),
                _=> Driver
            };

            Driver?.Manage().Window.Maximize();
            Driver?.Manage().Cookies.DeleteAllCookies();
            //Driver!.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
    }
}

