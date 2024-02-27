using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;

namespace ValueOfObjects.Steps
{
    internal class BaseSteps (IWebDriver driver)
    {
        protected readonly IWebDriver Driver = driver;
        protected LoginPage? LoginPage { get; set; }
        protected DashboardPage? DashboardPage { get; set; }
        protected  AddProjectPage? AddProjectPage { get; set; }
       
    }
}
