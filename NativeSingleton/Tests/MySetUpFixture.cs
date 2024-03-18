using NativeSingleton.Core;
using NativeSingleton.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeSingleton.Tests
{
    [SetUpFixture]
    internal class MySetUpFixture
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            BrowserSingleton.GetInstance().GetDriver().Navigate().GoToUrl(Helpers.Configuration.Configurator.AppSettings.URL);
            new NavigationSteps().SuccessfulLoginByAdmin();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            BrowserSingleton.GetInstance().CloseDriver();
        }
    }
}
