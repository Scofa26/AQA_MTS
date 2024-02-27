using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfInvocations.Pages;
using ChainOfInvocations.Pages.ProjectPages;

namespace ChainOfInvocations.Steps
{
    internal class BaseSteps (IWebDriver driver)
    {
        protected readonly IWebDriver Driver = driver;
        protected LoginPage? LoginPage { get; set; }
        protected DashboardPage? DashboardPage { get; set; }
        protected  AddProjectPage? AddProjectPage { get; set; }
       
    }
}
