using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Steps
{
    internal class AllureSteps : BaseSteps
    {
        public AllureSteps(IWebDriver driver) : base(driver)
        {
        }

        [AllureStep("Test {url}")]
        public void TestDomain([Name("Webpage URL")] string url)
        {
            // Добавление дополнительной информации
            AllureLifecycle.Instance.UpdateStep(stepResult =>
                stepResult.parameters.Add(
                    new Parameter
                    {
                        name = "Started at",
                        value = DateTime.Now.ToString()
                    }
                )
            );

            OpenBrowser();
            GoToWebpage(url);
            CloseBrowser();
        }

        [AllureStep("Open web browser")]
        private void OpenBrowser()
        {
            Assert.That(true);
        }

        [AllureStep("Visit {url}")]
        private void GoToWebpage([NUnit.Allure.Attributes.Skip] string url)
        {
            Assert.That(true);
        }

        [AllureStep("Close web browser")]
        private void CloseBrowser()
        {
            Assert.That(true);
        }
    }
}
