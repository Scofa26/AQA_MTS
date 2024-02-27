﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfInvocations.Pages;
using ChainOfInvocations.Steps;

namespace ChainOfInvocations.Steps
{
    internal class NavigationSteps(IWebDriver driver) : BaseSteps(driver)
    {
        // Комплексные
        public DashboardPage SuccessfulLogin(string username, string password)
        {
            return Login<DashboardPage>(username, password);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            return Login<LoginPage>(username, password);
        }

        private T Login<T>(string username, string password) where T : BasePage
        {
            LoginPage = new LoginPage(Driver);
            LoginPage.EmailInput.SendKeys(username);
            LoginPage.PswInput.SendKeys(password);
            LoginPage.LoginInButton.Click();

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }
    }
}
