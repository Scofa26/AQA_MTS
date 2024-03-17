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
    }
}
