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
    internal class BaseSteps
    {
        protected IWebDriver Driver;
        public LoginPage _loginPage => new LoginPage(Driver);
        public TestCaseBasePage _testCaseBasePage => new TestCaseBasePage(Driver);
        public AddTestCasePage _addTestcasePage => new AddTestCasePage(Driver);
        public BaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
