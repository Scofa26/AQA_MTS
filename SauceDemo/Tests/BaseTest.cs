using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PajeObjectSimple.Core;

namespace SauceDemo.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
       
        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
           
            Driver.Navigate().GoToUrl(PajeObjectSimple.Helpers.Configuration.Configurator.AppSettings.URL);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
