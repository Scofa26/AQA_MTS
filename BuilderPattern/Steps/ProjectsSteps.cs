using BuilderPattern.Models;
using BuilderPattern.Pages.ProjectPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Pages;
using BuilderPattern.Pages.ProjectPages;

namespace BuilderPattern.Steps
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
