using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjectSteps.Pages.ProjectPages;

namespace PageObjectSteps.Pages.ProjectPages
{
    internal class ProjectBasePage : BasePage
    {
        private static readonly By NameInputBy = By.Id("name");

        public ProjectBasePage(IWebDriver driver) : base(driver)
        {
        }

        public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}
