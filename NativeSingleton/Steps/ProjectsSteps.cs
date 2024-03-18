using NativeSingleton.Models;
using NativeSingleton.Pages.ProjectPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeSingleton.Pages;
using NativeSingleton.Pages.ProjectPages;

namespace NativeSingleton.Steps
{
    internal class ProjectsSteps : BaseSteps
    {
        public ProjectPage AddProject(Project project)
        {
            AddProjectPage = new AddProjectPage( true);

            AddProjectPage.NameInput.SendKeys(project.ProjectName);
            AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
            AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
            if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();

            AddProjectPage.AddButton.Click();

            return new ProjectPage();
        }
    }
}
