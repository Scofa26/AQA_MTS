using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Tests
{
    internal class SKFTest : BaseClass
    {

        [Test]
        public void ValidateSKF()
        {
            Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
            Driver.SwitchTo().Frame(0);  
            Thread.Sleep(3000);

            IWebElement ageInput = Driver.FindElement(By.Id("age"));
            ageInput.SendKeys("20");

            IWebElement sex = Driver.FindElement(By.Id("sex"));
            SelectElement selectSex = new SelectElement(sex);
            selectSex.SelectByValue("F");

            IWebElement crInput = Driver.FindElement(By.Id("cr"));
            crInput.SendKeys("12");

            IWebElement selectCr = Driver.FindElement(By.Id("cr-size"));
            SelectElement selectElementCr = new SelectElement(selectCr);
            selectElementCr.SelectByText("мкмоль/л");

            IWebElement selectRace = Driver.FindElement(By.Id("race"));
            SelectElement selectElementRace = new SelectElement(selectRace);
            selectElementRace.SelectByValue("O");

            IWebElement massInput = Driver.FindElement(By.Id("mass"));
            massInput.SendKeys("60");

            IWebElement growInput = Driver.FindElement(By.Id("grow"));
            growInput.SendKeys("170");

            IWebElement calcButton = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
            calcButton.Click();

            IWebElement mdrdResult = Driver.FindElement(By.Id("mdrd_res"));
            Assert.That(mdrdResult.Text, Is.EqualTo("708.21"));

            IWebElement mdrdResultDiagnosis = Driver.FindElement(By.XPath("//div[@id = 'mdrd']//span[@class='diagnosis']"));
            Assert.That(mdrdResultDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));

            IWebElement ckdEpiResult = Driver.FindElement(By.Id("ckd_epi_res"));
            Assert.That(ckdEpiResult.Text, Is.EqualTo("213.96"));

            IWebElement ckdEpiResultDiagnosis = Driver.FindElement(By.XPath("//div[@id = 'ckd_epi']//span[@class='diagnosis']"));
            Assert.That(ckdEpiResultDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));

            IWebElement cgeResult = Driver.FindElement(By.Id("cge_res"));
            Assert.That(cgeResult.Text, Is.EqualTo("626.18"));

            IWebElement schwartzResult = Driver.FindElement(By.Id("schwartz_res"));
            Assert.That(schwartzResult.Text, Is.EqualTo("694.17"));

            IWebElement schwartzResultDiagnosis = Driver.FindElement(By.XPath("//div[@id = 'schwartz']//span[@class='diagnosis']"));
            Assert.That(schwartzResultDiagnosis.Text, Is.EqualTo("Нормальный уровень СКФ (C1)"));
        }
    }
}
