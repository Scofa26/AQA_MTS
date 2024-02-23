
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Pages;
using PageObjectSteps.Tests;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            UserSteps userSteps = new UserSteps(Driver);
            DashboardPage dashboardPage = userSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.That(dashboardPage.IsPageOpened);
        }

        [Test]
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
