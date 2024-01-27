using OpenQA.Selenium;
using SeleniumBasic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    internal class FirstTest : BaseClass
    {
     

      
        [Test]
        public void ValidteIKTCalculationTest()
        {

             Driver = new Browser().Driver!;
            Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");

            IWebElement weightInput = Driver.FindElement(By.Name("weight"));
            IWebElement heightInput = Driver.FindElement(By.Name("height"));
            IWebElement calcButton = Driver.FindElement(By.Name("imt_calc"));
           

            weightInput.SendKeys("60");
            heightInput.SendKeys("170");
            calcButton.Click();
            IWebElement resultText = Driver.FindElement(By.Id("imt-result"));
            Assert.That(resultText.Text, Is.EqualTo("20.8 - Норма"));
           
        }

      
    }
}
