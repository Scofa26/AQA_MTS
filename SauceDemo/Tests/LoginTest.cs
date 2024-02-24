using OpenQA.Selenium;
using PageObjectSimple.Pages;
using PajeObjectSimple.Helpers.Configuration;
using PajeObjectSimple.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObjectSimple.Tests 
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void StandartUserSuccessfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            IventoryPage iventoryPage = loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);
        }

        [Test]
        public void LockedOutUsernameLoginTest()
        {
            Assert.That(
                new LoginPage(Driver)
                    .IncorrectLogin("locked_out_user", Configurator.AppSettings.Password)
                    .ErrorText.Text.Trim(),
                Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

        [Test]
        public void PerformanceGlitchUsernameLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            IventoryPage iventoryPage = loginPage.SuccessfulLogin("performance_glitch_user", Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);
        }

        [Test]
        public void ProblemUsernameLoginTest()
        {
            Assert.That(
                new LoginPage(Driver)
                    .IncorrectLogin("problem_user", "")
                    .ErrorText.Text.Trim(),
                Is.EqualTo("Epic sadface: Password is required"));
        }
    }
}
