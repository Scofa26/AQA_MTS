using Microsoft.Playwright;
using OpenQA.Selenium;
using SeleniumBasic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    [TestFixture]
    internal class WebDriverTest
    {
       
        [Test]
        public void FactoryDriverTest()
        {
            IWebDriver webDriver = new Browser().Driver!;
            webDriver.Navigate().GoToUrl("http://onliner.by");
            webDriver.Quit();
        }
    }
}
