using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Models;
using ValueOfObjects.Pages;
using ValueOfObjects.Pages.ProjectPages;
using ValueOfObjects.Steps;

namespace ValueOfObjects.Steps
{
    internal class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
    {
        public ProjectPage AddProject(Project project)
        {
            AddProjectPage = new AddProjectPage(Driver, true);

            AddProjectPage.NameInput.SendKeys(project.ProjectName);
            AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
            AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
            if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();

            AddProjectPage.AddButton.Click();

            return new ProjectPage(Driver);
        }
    }
}
