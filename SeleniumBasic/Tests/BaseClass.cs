using OpenQA.Selenium;
using SeleniumBasic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    internal class BaseClass
    {
        protected IWebDriver Driver { get; set; }

        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
