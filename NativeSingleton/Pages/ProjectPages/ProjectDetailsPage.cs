using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeSingleton.Pages.ProjectPages
{
    internal class ProjectDetailsPage(bool openByURL = false) : BasePage( openByURL)
    {
        private const string END_POINT = "";

        // Описание элементов
        private static readonly By OverviewTabBy = By.Id("navigation-projects");


        protected override bool EvaluateLoadedStatus()
        {
            return OverviewTab.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public IWebElement OverviewTab => WaitsHelper.WaitForExists(OverviewTabBy);
    }
}
