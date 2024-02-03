using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    internal class LaminateTest:BaseClass
    {
        [Test]
        public void ValidateLaminate()
        {
            Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/ ");

            IWebElement LnRoomInput = Driver.FindElement(By.Id("ln_room_id"));
            LnRoomInput.Clear();    
            LnRoomInput.SendKeys("500");

            IWebElement WdRoomInput = Driver.FindElement(By.Id("wd_room_id"));
            WdRoomInput.Clear();
            WdRoomInput.SendKeys("450");

            IWebElement LnLamInput = Driver.FindElement(By.Id("ln_lam_id"));
            LnLamInput.Clear();
            LnLamInput.SendKeys("1100");

            IWebElement WdLamInput = Driver.FindElement(By.Id("wd_lam_id"));
            WdLamInput.Clear();
            WdLamInput.SendKeys("100");

            IWebElement NPackingInput = Driver.FindElement(By.Id("n_packing"));
            NPackingInput.Clear();
            NPackingInput.SendKeys("15");

            IWebElement AreaInput = Driver.FindElement(By.Id("area"));
            AreaInput.Clear();
            AreaInput.SendKeys("100");

            IWebElement DirectionLaminateRadioButton = Driver.FindElement(By.XPath("//div[@class='input-ln']/label[./@for='direction-laminate-id1']"));
            DirectionLaminateRadioButton.Click();

            IWebElement LayingMethodLam = Driver.FindElement(By.Id("laying_method_laminate"));
            SelectElement selectElementLayingMethodLam = new SelectElement(LayingMethodLam);
            selectElementLayingMethodLam.SelectByValue("0");

            IWebElement CalcButton = Driver.FindElement(By.Id("btn_calculate"));
            CalcButton.Click();

            IWebElement CalcLamResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[1]//span"));
            Assert.That(CalcLamResult.Text, Is.EqualTo("225"));

            IWebElement CalcPackResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[2]//span"));
            Assert.That(CalcPackResult.Text, Is.EqualTo("15"));

            IWebElement CalcPriceResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[3]//span"));
            Assert.That(CalcPriceResult.Text, Is.EqualTo("0 руб"));

            IWebElement CalcWeightResult = Driver.FindElement(By.XPath("//div[@class='calc-result']//div[4]//span"));
            Assert.That(CalcWeightResult.Text, Is.EqualTo("0 кг"));
        }
    }
}
