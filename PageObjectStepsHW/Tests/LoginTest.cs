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
        [Test]
        public void SuccessfulLoginTest()
        {
            LoginPage _loginPage = new LoginPage(Driver);
            _loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
            _loginPage.PswInput.SendKeys(Configurator.AppSettings.Password);
            _loginPage.ClickLoginInButton();

            DashboardPage dashboardPage = new DashboardPage(Driver);

            Assert.That(dashboardPage.IsPageOpened);
        }

        [Test]
        public void SuccessfulLoginTest1()
        {
            UserSteps userSteps = new UserSteps(Driver);
            DashboardPage dashboardPage = userSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.That(dashboardPage.IsPageOpened);
        }

        //[Test]
        public void InvalidUsernameLoginTest()
        {
            // Проверка
            Assert.That(
                new UserSteps(Driver)
                    .IncorrectLogin("ssdd", "")
                    .GetErrorLabelText(),
                Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
        }
    }
}
