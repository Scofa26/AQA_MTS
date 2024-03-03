using Allure.Net.Commons;
using NUnit.Allure.Core;
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
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]
    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected NavigationSteps NavigationSteps { get; private set; }

        [OneTimeSetUp]
        public static void GlobalSetUo()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

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
            try
            {
                if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
                {
                    Screenshot screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                    byte[] screenshotBytes = screenshot.AsByteArray;

                    //Скриншот конкретного эл-та
                    // IWebElement test = Driver.FindElement(By.Id("dss"));
                    //Screenshot screenshot1 = ((ITakesScreenshot)Driver).GetScreenshot();

                    AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Driver.Quit();
        }
    }
}
