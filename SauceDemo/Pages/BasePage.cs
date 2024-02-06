using OpenQA.Selenium;
using PajeObjectSimple.Helpers.Configuration;
using SauceDemo.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObjectSimple.Pages
{
    internal class BasePage 
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver { get; private set; }
    }
}
