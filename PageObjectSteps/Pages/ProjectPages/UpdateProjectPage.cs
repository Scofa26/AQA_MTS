using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Allure.Helpers;

namespace Allure.Pages.ProjectPages
{
    internal class UpdateProjectPage : ProjectBasePage
    {
        private static string END_POINT = "index.php?/admin/projects/add";

        // Описание элементов
        private static readonly By SaveButtonBy = By.Id("name");



        public UpdateProjectPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        // Атомарные Методы
        public IWebElement SaveButton => WaitHelpers.WaitForExists(SaveButtonBy);
    }
}
