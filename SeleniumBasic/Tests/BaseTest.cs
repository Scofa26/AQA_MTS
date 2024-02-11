using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumAdvanced.Helpers;
using SeleniumAdvanced.Core;
using SeleniumAdvanced.Helpers.Configuration;

namespace SeleniumAdvanced.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }

        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
            WaitsHelper waitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        }
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
