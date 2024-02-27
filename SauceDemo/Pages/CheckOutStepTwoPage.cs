using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadableComponent.Pages;

namespace LoadableComponent.Pages
{
    internal class CheckOutStepTwoPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";
        private static readonly By TitleLabelBy = By.ClassName("title");
        private readonly By ProductBackpackBy = By.ClassName("inventory_item_name");
        private readonly By SummaryTotalLabelBy = By.CssSelector("[class~='summary_total_label']");
        private readonly By FinishButtonBy = By.Id("finish");


        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
        public IWebElement ProductBackpack => WaitHelpers.WaitForExists(ProductBackpackBy);
        public IWebElement SummaryTotalLabel => WaitHelpers.WaitForExists(SummaryTotalLabelBy);
        public IWebElement FinishButton => WaitHelpers.WaitForExists(FinishButtonBy);
        public bool FinishButtonVisible => WaitHelpers.WaitForVisibility(FinishButton);

        public CheckOutStepTwoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }
        
        public CheckOutCompletePage ClickFinishButton()
        {
            FinishButton.Click();
            return new CheckOutCompletePage(Driver, true);
        }
        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Overview");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
