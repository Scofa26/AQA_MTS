﻿using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectSteps.Core;
using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
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
