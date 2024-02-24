using OpenQA.Selenium;
using PageObjectSimple.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObjectSimple.Pages
{
    internal class LoginPage : BasePage
    {
        private static string END_POINT = "";

        private static readonly By UserNameInputBy = By.Id("user-name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By LoginInButtonBy = By.Id("login-button");
        private static readonly By ErrorTextBy = By.XPath("//h3[@data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        // Методы
        public IWebElement UserNameInput => WaitHelpers.WaitForExists(UserNameInputBy);
        public IWebElement PswInput => WaitHelpers.WaitForExists(PswInputBy);
        public IWebElement LoginInButton => WaitHelpers.WaitForExists(LoginInButtonBy);
        public IWebElement ErrorText => WaitHelpers.WaitForExists(ErrorTextBy);

        // Комплексные
        public IventoryPage SuccessfulLogin(string username, string password)
        {
            UserNameInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();
            return new IventoryPage(Driver, true);
        }
        public LoginPage IncorrectLogin(string username, string password)
        {
            UserNameInput.SendKeys(username);
            PswInput.SendKeys(password);
            LoginInButton.Click();
            return this;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && UserNameInput.Displayed;
        }
    }
}
