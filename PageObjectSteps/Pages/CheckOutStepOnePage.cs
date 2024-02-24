using OpenQA.Selenium;
using PageObjectSteps.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSteps.Pages
{
    internal class CheckOutStepOnePage : BasePage
    {
        private static string END_POINT = "checkout-step-one.html";
        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By FirstNameInputBy = By.Id("first-name");
        private static readonly By LastNameInputBy = By.Id("last-name");
        private static readonly By PostalCodeInputBy = By.Id("postal-code");
        private static readonly By ContinueButtonBy = By.Id("continue");

        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
        public IWebElement FirstNameInput => WaitHelpers.WaitForExists(FirstNameInputBy);
        public IWebElement LastNameInput => WaitHelpers.WaitForExists(LastNameInputBy);
        public IWebElement PostalCodeInput => WaitHelpers.WaitForExists(PostalCodeInputBy);
        public IWebElement ContinueButton => WaitHelpers.WaitForExists(ContinueButtonBy);

        public CheckOutStepOnePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }
        
        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Checkout: Your Information");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
