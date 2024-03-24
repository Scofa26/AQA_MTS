using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectStepsHW.Pages;
using PageObjectStepsHW.Pages.TestCasePages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Steps
{
    internal class UserSteps : BaseSteps
    {
        private LoginPage _loginPage;

        public UserSteps(IWebDriver driver) : base(driver)
        {
            _loginPage = new LoginPage(Driver);
        }

        // Комплексные
        [AllureStep]
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

        public AddTestCasePage AddTestCase()
        {
            _testCaseBasePage.AddTestCaseButton.Click();
            _addTestcasePage.TestCaseDropDwnOpen.Click();
            return new AddTestCasePage(Driver);
        }
    }
}
