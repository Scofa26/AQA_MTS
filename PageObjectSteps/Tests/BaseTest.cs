using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Allure.Core;
using Allure.Helpers;
using Allure.Steps;
using Allure.Helpers.Configuration;
using NUnit.Allure.Core;
using Allure.Net.Commons;

namespace Allure.Tests
{
    [Parallelizable(scope: ParallelScope.All)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    [AllureNUnit]

    internal class BaseTest
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitHelpers WaitHelpers { get; private set; }

        protected UserSteps UserSteps;
        protected AllureSteps AllureSteps;

        [OneTimeSetUp]
        public static void GlobalSetUo()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }
        [SetUp]
        public void FactoryDriverTest()
        {
            Driver = new Browser().Driver;
            WaitHelpers = new WaitHelpers(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

            UserSteps = new UserSteps(Driver);
            AllureSteps = new AllureSteps(Driver);  
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

                    // Прикрепление скриншота к отчету
                    // Вариант 1
                    AllureLifecycle.Instance.AddAttachment("Screenshot", "image/png", screenshotBytes);

                    // Вариант 2
                    AllureApi.AddAttachment("Screenshot", "image/png", screenshotBytes);
                    AllureApi.AddAttachment("data.txt", "text/plain", Encoding.UTF8.GetBytes("This os the file content."));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Driver.Quit();
        }
    }
}
