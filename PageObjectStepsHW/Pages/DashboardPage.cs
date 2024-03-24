using OpenQA.Selenium;
using PageObjectStepsHW.Elements;
using PageObjectStepsHW.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Pages
{
    internal class DashboardPage : BasePage
    {
        private static string END_POINT = "index.php?/dashboard";

        // Описание элементов
        private static readonly By TitleLabelBy = By.ClassName("page_title");
        private static readonly By AddProjectButtonBy = By.Id("sidebar-projects-add");
        private static readonly By AnyProjectWithTestCasesBy = By.XPath("//a[contains(text(),'Test Cases') and contains(@href, 'index.php?/suites/view/')]");

        // Инициализация класса
        public DashboardPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("All Projects");
        }

        // Атомарные Методы
        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
        public Button AddProjectButton => new(Driver, AddProjectButtonBy);
        public Button AnyProjectWithTestCases => new(Driver, AnyProjectWithTestCasesBy);

    }
}
