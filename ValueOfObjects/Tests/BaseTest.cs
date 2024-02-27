﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Core;
using ValueOfObjects.Helpers.Configuration;
using ValueOfObjects.Models;
using ValueOfObjects.Steps;

namespace ValueOfObjects.Tests
{
    //[Parallelizable(scope: ParallelScope.All)]
    //[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }

        protected NavigationSteps _navigationSteps;
        protected ProjectsSteps _projectSteps;

        protected User Admin { get; private set; }

        [SetUp]
        public void Setup()
        {
            Driver = new Browser().Driver;

            _navigationSteps = new NavigationSteps(Driver);
            _projectSteps = new ProjectsSteps(Driver);

            Admin = new User
            {
                Email = Configurator.AppSettings.Username,
                Password = Configurator.AppSettings.Password
            };

            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
