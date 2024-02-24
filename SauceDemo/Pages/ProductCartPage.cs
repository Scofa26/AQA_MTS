using OpenQA.Selenium;
using PajeObjectSimple.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSimple.Pages
{
    internal class ProductCartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        private static readonly By TitleLabelBy = By.ClassName("title");
        private static readonly By ItemLabelBy = By.ClassName("inventory_item_name");
        private static readonly By RemoveButtonBy = By.Id("remove-sauce-labs-backpack");
        private readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");
        private static readonly By CheckoutButtonBy = By.Id("checkout");

        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
        public IWebElement ItemLabel => WaitHelpers.WaitForExists(ItemLabelBy);
        public bool ItemLabelInvisibility => WaitHelpers.WaitForElementInvisible(ItemLabelBy);
        public bool ShoppingCartBadgeInvisibility => WaitHelpers.WaitForElementInvisible(ShoppingCartBadgeBy);
        public IWebElement RemoveButton => WaitHelpers.WaitForExists(RemoveButtonBy);
        public IWebElement CheckoutButton => WaitHelpers.WaitForExists(CheckoutButtonBy);

        public ProductCartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        public void ClickRemovebutton() => RemoveButton.Click();
        public CheckOutStepOnePage ClickCheckoutbutton()
        {
            CheckoutButton.Click();
            return new CheckOutStepOnePage(Driver, true);
        }
       
        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Your Cart");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }
    }
}
