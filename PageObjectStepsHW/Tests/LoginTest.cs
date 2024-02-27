using ChainOfInvocations.Helpers.Configuration;
using ChainOfInvocations.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfInvocations.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            DashboardPage dashboardPage = _navigationSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Assert.That(dashboardPage.IsPageOpened);
        }

        [Test]
        public void InvalidUsernameLoginTest()
        {
            // Проверка
            Assert.That(
                _navigationSteps
                    .IncorrectLogin("ssdd", "")
                    .GetErrorLabelText(),
                Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
        }
    }
}
