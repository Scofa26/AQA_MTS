using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectSteps.Helpers;
using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Core;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Tests
{
    //[Parallelizable(scope: ParallelScope.All)]
   // [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitHelpers WaitHelpers { get; private set; }

        protected UserSteps UserSteps;

        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
            WaitHelpers = new WaitHelpers(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

            UserSteps = new UserSteps(Driver);

            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
