using OpenQA.Selenium;
using PageObjectStepsHW.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Pages.ProjectPages
{
    internal class ProjectBasePage : BasePage
    {
        private static readonly By NameInputBy = By.Id("name");
        private static readonly By ProjectTypeRadioButtonBy = By.Name("suite_mode");
        private static readonly By ProjectTypeCheckBoxBy = By.Name("show_announcement");
        private static readonly By ProjectTabsAccessBy = By.Id("projects-tabs-access");
        private static readonly By AddProjectsTableBy = By.CssSelector("table.grid");
        private static readonly By AddProjectsTablesDropDownOpenBy = By.PartialLinkText("#userAccessDropdown");
        private static readonly By AccessDropDownBy = By.ClassName("dropdown-menu-link");

        public ProjectBasePage(IWebDriver driver) : base(driver)
        {
        }

        public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        // Атомарные Методы
        public RadioButton ProjectTypeRadioButton => new RadioButton(Driver, ProjectTypeRadioButtonBy);
        public DropDown AccessDropDown => new DropDown(Driver, AccessDropDownBy);
        public Button ProjectTabsAccess => new Button(Driver, ProjectTabsAccessBy);
        public Button AddProjectsTablesDropDownOpen => new Button(Driver, AddProjectsTablesDropDownOpenBy);
        public Checkbox ProjectCheckBox => new Checkbox(Driver, ProjectTypeCheckBoxBy);
        public Table AddProjectsTable => new(Driver, AddProjectsTableBy);

    }
}
