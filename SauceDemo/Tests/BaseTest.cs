using OpenQA.Selenium;
using SauceDemo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class BaseTest
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
