using BuilderPattern.Models;
using BuilderPattern.Pages;
using BuilderPattern.Pages.ProjectPages;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Steps
{
    internal class NavigationSteps : BaseSteps
    {
        public NavigationSteps(IWebDriver driver) : base(driver) { }

        public LoginPage NavigateToLoginPage()
        {
            return new LoginPage(Driver);
        }

        public DashboardPage NavigateToDashboardPage()
        {
            return new DashboardPage(Driver);
        }

        public AddProjectPage NavigateToAddProjectPage()
        {
            return new AddProjectPage(Driver);
        }

        public DashboardPage SuccessfulLogin(User user)
        {
            return Login<DashboardPage>(user);
        }

        public LoginPage IncorrectLogin(User user)
        {
            return Login<LoginPage>(user);
        }

        public T Login<T>(User user) where T : BasePage
        {
            LoginPage = new LoginPage(Driver);

            LoginPage.EmailInput.SendKeys(user.Email);
            LoginPage.PswInput.SendKeys(user.Password);
            LoginPage.LoginInButton.Click();

            return (T)Activator.CreateInstance(typeof(T), Driver, false);
        }
    }
}
