using OpenQA.Selenium;
using SauceDemo.Utilites.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    internal class BasicLocatorsTests:BaseTest
    {
        [Test]
        public void BasicLocators()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            Assert.That(Driver.FindElement(By.Id("user-name")).Displayed);
            Assert.That(Driver.FindElement(By.Name("password")).Displayed);
            Assert.That(Driver.FindElement(By.ClassName("login_logo")).Text, Is.EqualTo("Swag Labs"));
            Assert.That(Driver.FindElements(By.TagName("input")).Count, Is.EqualTo(3));
            Assert.That(Driver.FindElements(By.LinkText("https://www.selenium.dev/documentation/webdriver/elements/finders/")).Count, Is.EqualTo(0));
            Assert.That(Driver.FindElements(By.PartialLinkText("documentation/webdriver")).Count, Is.EqualTo(0));
        }
    }
}
