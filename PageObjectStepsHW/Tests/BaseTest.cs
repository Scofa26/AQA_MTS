using OpenQA.Selenium;
using PageObjectStepsHW.Core;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Tests
{
    //[Parallelizable(scope: ParallelScope.All)]
    //[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected NavigationSteps NavigationSteps { get; private set; }

        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
            NavigationSteps = new NavigationSteps(Driver);

            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
