using BuilderPattern.Elements;
using BuilderPattern.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Helpers;

namespace BuilderPattern.Pages.ProjectPages
{
    internal class ProjectBasePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private static readonly By NameInputBy = By.Id("name");
        private static readonly By AnnouncementTextAreaBy = By.Id("announcement_display");
        private static readonly By ShowAnnouncementCheckBoxBy = By.Id("show_announcement");
        private static readonly By TypeRadioButtonBy = By.Name("suite_mode");

        // Атомарные Методы
        public IWebElement NameInput => WaitsHelper.WaitForExists(NameInputBy);
        public IWebElement AnnouncementTextArea => WaitsHelper.WaitForExists(AnnouncementTextAreaBy);
        public IWebElement ShowAnnouncementCheckBox => WaitsHelper.WaitForExists(ShowAnnouncementCheckBoxBy);
        public RadioButton TypeRadioButton => new RadioButton(Driver, TypeRadioButtonBy);

        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}
