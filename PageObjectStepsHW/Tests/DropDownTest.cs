using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Pages.ProjectPages;
using PageObjectStepsHW.Pages.TestCasePages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectStepsHW.Elements;
using NUnit.Framework.Internal;

namespace PageObjectStepsHW.Tests
{
    internal class DropDownTest : BaseTest
    {
        [Test]
        public void TestCaseDropDownTest()
        {
            UserSteps
                 .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                 .AnyProjectWithTestCases.Click();

           UserSteps
                .AddTestCase()
                .DropDownTestCase.SelectByText("Test Case (Steps)");
        }
    }
}
