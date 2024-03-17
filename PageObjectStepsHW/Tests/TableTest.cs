using PageObjectStepsHW.Elements;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Pages.Administration;
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
    }
}
