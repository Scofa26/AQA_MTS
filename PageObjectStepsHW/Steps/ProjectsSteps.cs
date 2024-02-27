using ChainOfInvocations.Pages;
using ChainOfInvocations.Pages.ProjectPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfInvocations.Steps
{
    internal class ProjectsSteps : BaseSteps
    {
        public ProjectsSteps(IWebDriver driver) : base(driver)
        {
            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            DashboardPage dashboardPage = new DashboardPage(Driver);
        }

        public void AddProductToCart(List<string> Products)
        {
        }

        public void CreateProject()
        {

        }

        public void UpdateProject()
        {

        }

        public void ReadProject()
        {

        }

        public void DeleteProject()
        {

        }
    }
}
