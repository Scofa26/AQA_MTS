using OpenQA.Selenium;
using PajeObjectSimple.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSimple.Pages
{
    internal class CheckOutCompletePage : BasePage
    {
        private static string END_POINT = "checkout-complete.html";
        private static readonly By TitleLabelBy = By.ClassName("title");
        private readonly By ComleteLabelBy = By.ClassName("complete-header");
        private readonly By BackHomeButtonBy = By.Id("back-to-products");


        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
        public IWebElement ComleteLabel => WaitHelpers.WaitForExists(ComleteLabelBy);
        public IWebElement BackHomeButton => WaitHelpers.WaitForExists(BackHomeButtonBy);
        public bool BackHomeButtonVisible => WaitHelpers.WaitForVisibility(BackHomeButton);

        public CheckOutCompletePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public IventoryPage ReturnHomePage()
        {
            BackHomeButton.Click();
            return new IventoryPage(Driver, true);
        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Complete!");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
