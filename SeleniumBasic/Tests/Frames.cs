using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.Tests
{
    public class Frames : BaseTest
    {
        [Test]
        public void FramesTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/frames");
            WaitsHelper.WaitForExists(By.LinkText("iFrame")).Click();

            Driver.SwitchTo().Frame("mce_0_ifr");

            Assert.That(WaitsHelper.WaitForExists(By.XPath("//p")).Text, Is.EqualTo("Your content goes here."));
        }
    }
}
