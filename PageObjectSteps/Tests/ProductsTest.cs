
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectSteps.Tests;
using PageObjectSteps.Steps;
using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Pages;

namespace PageObjectSteps.Tests
{
    internal class ProductsTest : BaseTest
    {
        [Test]
        public void AddProductToCart()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);
            
            iventoryPage.ClickAddToCartBackBackButton();
            int countProductAfter = Convert.ToInt32(iventoryPage.ShoppingCartBadge.Text);

            Assert.Multiple(() =>
            {
                Assert.That(iventoryPage.RemoveBackpackButton.Text, Is.EqualTo("Remove"));
                Assert.That(countProductAfter, Is.EqualTo(1)); // Проверка, что кол-во эл-ов в shopping_cart_badge = 1, т.к. в тесте добавляется только 1 продукт 
            });

            ProductCartPage productCartPage = NavigationSteps.ClickShoppingCartLink();

            Assert.Multiple(() =>
            {
                Assert.That(productCartPage.IsPageOpened());
                Assert.That(productCartPage.ItemLabel.Text, Is.EqualTo("Sauce Labs Backpack"));
            });
        }

        [Test]
        public void RemoveProductToCart()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);

            iventoryPage.ClickAddToCartBackBackButton();
            ProductCartPage productCartPage = NavigationSteps.ClickShoppingCartLink();

            Assert.Multiple(() =>
            {
                Assert.That(productCartPage.IsPageOpened());
                Assert.That(productCartPage.ItemLabel.Text, Is.EqualTo("Sauce Labs Backpack"));
            });

            productCartPage.ClickRemovebutton();

            Assert.Multiple(() =>
            {
                Assert.That(productCartPage.IsPageOpened());
                Assert.That(productCartPage.ItemLabelInvisibility, Is.EqualTo(true));
                Assert.That(productCartPage.ShoppingCartBadgeInvisibility, Is.EqualTo(true));
            });
        }

        [Test]
        public void CheckPayment()
        {
            IventoryPage iventoryPage = NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
            Assert.That(iventoryPage.IsPageOpened);

            iventoryPage.ClickAddToCartBackBackButton();
            ProductCartPage productCartPage = NavigationSteps.ClickShoppingCartLink();

            Assert.Multiple(() =>
            {
                Assert.That(productCartPage.IsPageOpened());
                Assert.That(productCartPage.ItemLabel.Text, Is.EqualTo("Sauce Labs Backpack"));
            });
            
            CheckOutStepOnePage checkOutStepOnePage = NavigationSteps.ClickCheckoutbutton();
            Assert.That(checkOutStepOnePage.IsPageOpened);

            CheckOutStepTwoPage checkOutStepTwoPage = NavigationSteps.CheckInfo("Sonya", "Chida", "89202");

            Assert.Multiple(() =>
            {
                Assert.That(checkOutStepTwoPage.IsPageOpened);
                Assert.That(checkOutStepTwoPage.ProductBackpack.Text.Trim(), Is.EqualTo("Sauce Labs Backpack"));
                Assert.That(checkOutStepTwoPage.SummaryTotalLabel.Text.Trim(), Is.EqualTo("Total: $32.39"));
                Assert.That(checkOutStepTwoPage.FinishButtonVisible, Is.EqualTo(true));
            });

            CheckOutCompletePage checkOutCompletePage = NavigationSteps.ClickFinishButton();

            Assert.Multiple(() =>
            {
                Assert.That(checkOutCompletePage.IsPageOpened);
                Assert.That(checkOutCompletePage.ComleteLabel.Text.Trim(), Is.EqualTo("Thank you for your order!"));
                Assert.That(checkOutCompletePage.BackHomeButtonVisible, Is.EqualTo(true));
            });

            IventoryPage iventoryPageAfterCompleteOrder = NavigationSteps.ReturnHomePage();
            Assert.That(iventoryPageAfterCompleteOrder.IsPageOpened());
        }
    }
}
