using OpenQA.Selenium;
using SauceDemo.Utilites.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    internal class CssSelectorTests : BaseTest
    {
        [Test]
        public void CssSelectorTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            Assert.That(Driver.FindElement(By.CssSelector(".login_logo")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".input_error.form_input")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector(".form_group .input_error")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("#login_button_container")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("input")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("div .login-box")).Displayed);
            Assert.That(Driver.FindElement(By.CssSelector("[class='login_credentials_wrap']")).Displayed);
            Assert.That(Driver.FindElements(By.CssSelector("[class~='form_input']")).Count, Is.EqualTo(2));
            Assert.That(Driver.FindElement(By.CssSelector("[name|='login']")).Displayed);
            Assert.That(Driver.FindElements(By.CssSelector("[class~='form_input']")).Count, Is.EqualTo(2));
            Assert.That(Driver.FindElement(By.CssSelector("input[class$='btn_action']")).Displayed);
            Assert.That(Driver.FindElements(By.CssSelector("[class*='credentials']")).Count, Is.EqualTo(3));
        }
    }
}
