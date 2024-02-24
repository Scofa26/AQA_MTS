using OpenQA.Selenium;
using PageObjectSteps.Pages;
using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectSteps.Tests;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void StandartUserSuccessfulLoginTest()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);
        }

        [Test]
        public void LockedOutUsernameLoginTest()
        {
            Assert.That(
                NavigationSteps
                    .IncorrectLogin("locked_out_user", Configurator.AppSettings.Password)
                    .ErrorText.Text.Trim(),
                Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [Test]
        public void PerformanceGlitchUsernameLoginTest()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin("performance_glitch_user", Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);
        }

        [Test]
        public void ProblemUsernameLoginTest()
        {
            Assert.That(
                NavigationSteps
                    .IncorrectLogin("problem_user", "")
                    .ErrorText.Text.Trim(),
                Is.EqualTo("Epic sadface: Password is required"));
        }
    }
}
