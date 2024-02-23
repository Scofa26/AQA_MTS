using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjectSteps.Pages;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Steps
{
    internal class UserSteps : BaseSteps
    {
        private LoginPage _loginPage;

        public UserSteps(IWebDriver driver) : base(driver)
        {
            _loginPage = new LoginPage(Driver);
        }

        // Комплексные
        public DashboardPage SuccessfulLogin(string username, string password)
        {
            _loginPage.EmailInput.SendKeys(username);
            _loginPage.PswInput.SendKeys(password);
            _loginPage.ClickLoginInButton();

            return new DashboardPage(Driver);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            _loginPage.EmailInput.SendKeys(username);
            _loginPage.PswInput.SendKeys(password);
            _loginPage.LoginInButton.Click();

            return _loginPage;
        }
    }
}
