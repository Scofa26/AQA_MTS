using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Pages
{
    internal class ProductPage : BasePage
    {
        private static readonly By TitleLabelBy = By.ClassName("title");

        private static string END_POINT = "index.php?/dashboard";

        public ProductPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement TitleLabel => Driver.FindElement(TitleLabelBy);

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }
    }
}
