using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumAdvanced.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.Tests
{
    public class DynamicControls : BaseTest
    {
        [Test]
        public void DynamicControlsTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_controls");
            Driver.FindElement(By.XPath("//button[text()='Remove']")).Click();

            Assert.Multiple(() =>
            {
                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
                Assert.That(WaitsHelper.WaitForElementInvisible(By.Id("checkbox")));
            });

            IWebElement input = WaitsHelper.WaitForExists(By.XPath("//input[@type='text']"));

            Assert.That(!input.Enabled);

            Driver.FindElement(By.XPath("//button[text()='Enable']")).Click();

            Assert.Multiple(() =>
            {
                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
                Assert.That(input.Enabled);
            });
        }
    }
}
