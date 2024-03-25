using PageObjectStepsHW.Elements;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Pages.Administration;
using PageObjectStepsHW.Pages.ProjectPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Tests
{
    internal class TableTest : BaseTest
    {
        [Test]
        public void AddProjectCorrectTest()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            ProjectsPage projectsPage = new ProjectsPage(Driver, true);
            TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "Test2", "Project");
            tableCell.GetLink().Click();
        }


        [Test]
        public void AddProjectAcsessTest()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            addProjectPage.ProjectTabsAccess.Click();

            TableCell tableCell = addProjectPage.AddProjectsTable.GetCell("Project Access", "-", "Project Access");
            tableCell.GetLink().Click();

            addProjectPage.AccessDropDown.SelectByText("Lead");
            Assert.That(tableCell.Text.Equals("Lead"));
        }
    }
}
