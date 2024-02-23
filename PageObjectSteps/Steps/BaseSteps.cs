using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjectSteps.Steps;

namespace PageObjectSteps.Steps
{
    internal class BaseSteps
    {
        protected IWebDriver Driver;

        public BaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
