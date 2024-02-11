using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.Tests
{
    internal class ContextMenu : BaseTest
    {
        [Test]
        public void AlertTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/context_menu");

            Actions action = new Actions(Driver);
            action
                .ContextClick(Driver.FindElement(By.XPath("//div[@class='example']//div")))
                .Build()
                .Perform();

            IAlert alert = Driver.SwitchTo().Alert();
            Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));
            alert.Accept();
        }
    }
}
