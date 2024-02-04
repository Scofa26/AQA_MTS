using OpenQA.Selenium;
using SauceDemo.Utilites.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SauceDemo.Tests
{
    internal class XPathTests : BaseTest
    {
        [Test]
        public void XPathTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            Assert.That(Driver.FindElement(By.XPath("//div[@class='form_group'][1]")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//h4[text()='Accepted usernames are:']")).Displayed);
            Assert.That(Driver.FindElements(By.XPath("//div[contains(@class,'login')]")).Count, Is.EqualTo(9));
            Assert.That(Driver.FindElement(By.XPath("//h4[contains(text(),'Password for')]")).Displayed);
            Assert.That(Driver.FindElements(By.XPath("//*[@class='login_wrapper']/ancestor::div")).Count, Is.EqualTo(2));
            Assert.That(Driver.FindElement(By.XPath("//form/descendant::input[@id='password']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//div[@class='login-box']/following::div[@class='login_credentials_wrap']")).Displayed);
            Assert.That(Driver.FindElement(By.XPath("//form/parent::div")).Displayed);
            Assert.That(Driver.FindElements(By.XPath("//div[@class='login_credentials_wrap']/preceding::div")).Count, Is.EqualTo(7));
            Assert.That(Driver.FindElement(By.XPath("//input[@class='input_error form_input' and @name='user-name']")).Displayed);
        }
    }
}
