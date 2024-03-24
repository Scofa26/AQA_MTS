using OpenQA.Selenium;
using PageObjectStepsHW.Elements;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Pages.ProjectPages;
using PageObjectStepsHW.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Tests
{
    internal class ProjectsTest : BaseTest
    {
        [Test]
        public void ProjectRadioButtonTest()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            addProjectPage.ProjectTypeRadioButton.SelectByValue("2");
            Assert.That(addProjectPage.ProjectTypeRadioButton.IsSelected("2"));
        }

        [Test]
        public void ProjectCheckBoxTest()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProjectButton.Click();

            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            addProjectPage.ProjectCheckBox.SelectByValue("1");
            Assert.That(addProjectPage.ProjectCheckBox.IsSelected("1"));

        }

        [Test]
        public void TmpTest()
        {
            UserSteps
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            Driver.Navigate().GoToUrl("https://ac0502.testrail.io/index.php?/admin/site_settings#");
            RadioButton tmpElement = new(Driver, By.Name("restore_backup"));

            tmpElement.SelectByIndex(3);
        }
    }
}
