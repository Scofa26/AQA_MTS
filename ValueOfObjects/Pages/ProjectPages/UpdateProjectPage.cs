using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfObjects.Pages.ProjectPages
{
    internal class UpdateProjectPage(IWebDriver? driver, bool openByURL = false) : ProjectBasePage(driver, openByURL)
    {
        private const string END_POINT = "index.php?/admin/projects/add";

        // Описание элементов
        private static readonly By SaveButtonBy = By.Id("name");

        protected override bool EvaluateLoadedStatus()
        {
            return WaitsHelper.WaitForExists(SaveButtonBy).Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        // Атомарные Методы
        public IWebElement SaveButton => WaitsHelper.WaitForExists(SaveButtonBy);
    }
}
