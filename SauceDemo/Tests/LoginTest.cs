using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSimple.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            // Простой вид
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            DashboardPage dashboardPage = new DashboardPage(Driver);

            // Проверка 
            Assert.That(dashboardPage.IsPageOpened);
        }

        [Test]
        public void InvalidUsernameLoginTest()
        {
            // Проверка
            Assert.That(
                new LoginPage(Driver)
                    .IncorrectLogin("ssdd", "as21231")
                    .ErrorLabel.Text.Trim(),
                Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
        }
    }
}
