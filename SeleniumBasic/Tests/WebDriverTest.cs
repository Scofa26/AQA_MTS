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
        public void Test() 
        {
            

            IWebDriver webDriver = new SimpleDriver().Driver;
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl("https://gmodz.ru/kak-zapystit-kod-v-terminale-v-vs-code/");
            webDriver.Quit();
        }

        [Test]
        public void AdvancedDriverTest()
        {
            IWebDriver webDriver = new AdvancedDriver().GetChromeDriver();
            webDriver.Navigate().GoToUrl("http://onliner.by");
            webDriver.Quit();
        }

        [Test]
        public void FactoryDriverTest()
        {
            IWebDriver webDriver = new Browser().Driver!;
            webDriver.Navigate().GoToUrl("http://onliner.by");
            webDriver.Quit();
        }
    }
}
