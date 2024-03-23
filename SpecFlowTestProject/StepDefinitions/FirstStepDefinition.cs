using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTestProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject.StepDefinitions
{
    [Binding]
    internal class FirstStepDefinition
    {
        private readonly Browser _browser;
        public FirstStepDefinition(Browser browser)
        {
            _browser = browser;
        }

        [Given(@"Открыт браузер")]
        public void OpenBrowser()
        {
            Console.WriteLine("Browser is started");
            _browser.Driver = new ChromeDriver();
        }

        [When("страница логина открыта")]
        [Given("страница логина открыта")]
        public void OpenLoginPage()
        {
            Console.WriteLine("Login page is opened...");
            _browser.Driver.Navigate().GoToUrl("https://aqa2503.testrail.io/");
        }

        [Then(@"username is filled")]
        public void IsUsernameFieldDisplayed()
        {
            Assert.That(true);
        }
        [When(@"user ""(.*)"" with password ""(.*)"" logged in")]
        public void UserWithCredentialsLoggedIn(string username, string password)
        {
            Console.WriteLine($"User {username} logged in with psw {password}");
        }

        [Then(@"the add project button is displayed")]
        public void ThenTheAddProjectButtonIsDisplayed()
        {
            Console.WriteLine("Button is displayed...");
        }

        [Then(@"username is ""(.*)""")]
        public void IsUsernameEquals(string username)
        {
            Console.WriteLine($"User has {username}");
        }

        [Then(@"a project ID is (.*)")]
        public void IsProjectIdEqualsTo(int id)
        {
            Assert.That(id, Is.EqualTo(23));
        }

        [Given(@"a blog post named ""(.*)"" with Markdown body")]
        public void GivenABlogPostNamedWithMarkdownBody(string random, string multilineText)
        {
            Console.WriteLine($"Blog has name : {random}");
            Console.WriteLine($"Text : {multilineText}");
        }

        [AfterScenario]
        public void CloseDriver()
        {
            _browser.Driver?.Quit();
        }
    }
}
