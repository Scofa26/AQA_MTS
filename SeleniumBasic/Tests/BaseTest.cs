using OpenQA.Selenium;
using Locators.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locators.Tests
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
