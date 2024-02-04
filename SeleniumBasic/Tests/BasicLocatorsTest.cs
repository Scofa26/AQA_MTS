﻿using Locators.Utilites.Configuration;
using Microsoft.Playwright.NUnit;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locators.Tests
{
    internal class BasicLocatorsTest : BaseTest
    {
        [Test]
        public void basicLocatorsTest_1()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            // Find webElement by ID
            Driver.FindElement(By.Id("name")).SendKeys(Configurator.AppSettings.Username);

            // Find webElement by Name
            Driver.FindElement(By.Name("password")).SendKeys(Configurator.AppSettings.Password);

            // Find webElement by TagName
            Driver.FindElement(By.TagName("button")).Click();
        }

        [Test]
        public void basicLocatorsTest_2()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);

            // Find webElement by linkText
            Driver.FindElement(By.LinkText("Forgot your password?")).Click();

            // Find webElement by className
            Driver.FindElement(By.ClassName("forgot_passwordpage-request-cancel")).Click();

            // Find webElement by linkText
            Driver.FindElement(By.PartialLinkText("your password?")).Click();
        }
    }
}
