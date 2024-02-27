using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadableComponent.Pages;
using LoadableComponent.Helpers;

namespace LoadableComponent.Pages
{
    internal class LoginPage(IWebDriver? driver) : BasePage(driver)
    {
        private const string END_POINT = "";

        // Описание элементов
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-testid='loginErrorText']");

        // Инициализация класса
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        // Методы
        public IWebElement EmailInput => WaitHelpers.WaitForExists(EmailInputBy);
        public IWebElement ErrorLabel => WaitHelpers.WaitForExists(ErrorLabelBy);
        public IWebElement PswInput => WaitHelpers.WaitForExists(PswInputBy);
        public IWebElement RememberMeCheckbox => WaitHelpers.WaitForExists(RememberMeCheckboxBy);
        public IWebElement LoginInButton => WaitHelpers.WaitForExists(LoginInButtonBy);

        // Комплексные
        public DashboardPage SuccessfulLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return new DashboardPage(Driver);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            EmailInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();

            return this;
        }
    }
}
