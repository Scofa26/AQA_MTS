using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfInvocations.Pages.ProjectPages
{
    internal class AddProjectPage : ProjectBasePage
    {
        private static string END_POINT = "index.php?/admin/projects/add";

        // Описание элементов
        private static readonly By AddButtonBy = By.Id("name");

        public AddProjectPage(IWebDriver driver) : base(driver)
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
        public IWebElement AddButton => Driver.FindElement(AddButtonBy);
    }
}
