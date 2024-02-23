using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObjectSimple.Pages.ProjectPages
{
    internal abstract class ProjectBasePage : BasePage
    {
        private static readonly By NameInputBy = By.Id("name");

        public ProjectBasePage(IWebDriver driver) : base(driver)
        {
        }

        public ProjectBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

      
    }
}
