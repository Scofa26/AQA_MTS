using PajeObjectSimple.Helpers.Configuration;
using PajeObjectSimple.Pages;
using SauceDemo.Tests;
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
        public void SuccessfulLoginTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.EmailInput.SendKeys(Configurator.AppSettings.Username);
        }
    }
}
