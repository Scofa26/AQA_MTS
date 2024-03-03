using Allure.Net.Commons;
using NUnit.Allure;
using NUnit.Allure.Attributes;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Pages;
using PageObjectStepsHW.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Tests
{
    [Category("Authorization tests")]
    internal class LoginTest : BaseTest
    {
        [Test(Description = "Login test with statndart user and pass")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Scofa")]
        public void StandartUserSuccessfulLoginTest()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            AllureApi.AddTestParameter(Configurator.AppSettings.Username, Configurator.AppSettings.Password, ParameterMode.Masked);
            Assert.That(iventoryPage.IsPageOpened);
        }

        [Test(Description = "Login test with lockedout user")]
        [AllureSeverity(SeverityLevel.blocker)]
        [AllureOwner("Scofa")]
        public void LockedOutUsernameLoginTest()
        {
            AllureApi.AddAttachment("Error.txt", "text/plain", Encoding.UTF8.GetBytes("Epic sadface: Sorry, this user has been locked out."));

            Assert.That(
                NavigationSteps
                    .IncorrectLogin("locked_out_user", Configurator.AppSettings.Password)
                    .ErrorText.Text.Trim(),
                Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [Test(Description = "Login test with performance glitch user and pass")]
        [AllureSeverity(SeverityLevel.minor)]
        [AllureOwner("Scofa")]
        public void PerformanceGlitchUsernameLoginTest()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin("performance_glitch_user", Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);
        }

        [Test(Description = "Login test with problem user")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Scofa")]
        public void ProblemUsernameLoginTest()
        {
            Assert.That(
                NavigationSteps
                    .IncorrectLogin("problem_user", "")
                    .ErrorText.Text.Trim(),
                Is.EqualTo("Epic sadface: Password is required"));
        }

        [Test(Description = "Failed Login test for test screenshot")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Scofa")]
        public void FailedLoginTest()
        {
            Assert.That(
                NavigationSteps
                    .IncorrectLogin("problem_user", "")
                    .ErrorText.Text.Trim(),
                Is.EqualTo("???"));
        }
    }
}
