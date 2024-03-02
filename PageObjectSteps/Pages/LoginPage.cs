using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Pages
{
    internal class LoginPage : BasePage
    {
        private static string END_POINT = "";

        // Описание элементов
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-testid='loginErrorText']");

        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        // Методы
        public IWebElement EmailInput => WaitHelpers.WaitForExists(EmailInputBy);
        public IWebElement ErrorLabel => WaitHelpers.WaitForExists(ErrorLabelBy);
        public IWebElement PswInput => WaitHelpers.WaitForExists(PswInputBy);
        public IWebElement RememberMeCheckbox => WaitHelpers.WaitForExists(RememberMeCheckboxBy);
        public IWebElement LoginInButton => WaitHelpers.WaitForExists(LoginInButtonBy);



        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        // Методы действий с элементами
        public void ClickLoginInButton() => LoginInButton.Click();

        // Методы получения свойств
        public string GetErrorLabelText() => ErrorLabel.Text.Trim();
    }
}
