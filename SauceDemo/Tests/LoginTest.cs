using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadableComponent.Helpers.Configuration;
using LoadableComponent.Pages;
using LoadableComponent.Tests;

namespace LoadableComponent.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.Load();

            loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Driver.Navigate().GoToUrl("https://aqa2503.testrail.io/index.php?/mysettings");

            DashboardPage dashboardPage = new DashboardPage(Driver);
            dashboardPage.SidebarProjectsAddButton.Click();
        }
    }
}
