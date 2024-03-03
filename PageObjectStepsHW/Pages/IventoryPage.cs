using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Pages
{
    internal class IventoryPage : BasePage
    {
        private static string END_POINT = "inventory.html";

        private static readonly By TitleLabelBy = By.ClassName("title");
        private readonly By ProductBackpackBy = By.ClassName("inventory_item_name");
        private readonly By AddBackpackButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By RemoveBackpackButtonBy = By.Id("remove-sauce-labs-backpack");
        private readonly By ShoppingCartBadgeBy = By.ClassName("shopping_cart_badge");
        private readonly By ShoppingCartLinkBy = By.ClassName("shopping_cart_link");

        public IWebElement TitleLabel => WaitHelpers.WaitForExists(TitleLabelBy);
        public IWebElement BackpackLabel => WaitHelpers.WaitForExists(ProductBackpackBy);
        public IWebElement AddBackpackButton => WaitHelpers.WaitForExists(AddBackpackButtonBy);
        public IWebElement RemoveBackpackButton => WaitHelpers.WaitForExists(RemoveBackpackButtonBy);
        public IWebElement ShoppingCartLink => WaitHelpers.WaitForExists(ShoppingCartLinkBy);
        public IWebElement ShoppingCartBadge => WaitHelpers.WaitForExists(ShoppingCartBadgeBy);

        public IventoryPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {

        }

        public override bool IsPageOpened()
        {
            return TitleLabel.Text.Trim().Equals("Products");
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public void ClickAddToCartBackBackButton() => AddBackpackButton.Click();
    }
}
