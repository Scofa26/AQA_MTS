using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfInvocations.Pages;

namespace ChainOfInvocations.Pages.ProjectPages
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

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }
    }
}
