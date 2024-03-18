using NativeSingleton.Core;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeSingleton.Tests
{
 
    [TestFixture]
    internal class LoginTest : BaseTest
    {
        [Test]
        [Order(1)]
        public void SuccessfulLoginTest()
        {
            IWebDriver driver = BrowserSingleton.GetInstance().GetDriver();
            driver.Navigate().GoToUrl("https://yandex.ru/video/preview/7054751654127991095");
        }
    }
}
