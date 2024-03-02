using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Allure.Helpers;

namespace Allure.Pages
{
    internal class DashboardPage : BasePage
    {
        private static readonly By TitleLabelBy = By.ClassName("page_title");
        private static string END_POINT = "index.php?/dashboard";

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

        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
    }
}
