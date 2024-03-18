using NativeSingleton.Pages.ProjectPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeSingleton.Pages;

namespace NativeSingleton.Steps
{
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]

    internal class BaseSteps()
    {
        protected LoginPage? LoginPage { get; set; }
        protected DashboardPage? DashboardPage { get; set; }
        protected AddProjectPage? AddProjectPage { get; set; }

    }
}
