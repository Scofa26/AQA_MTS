﻿using OpenQA.Selenium;
using PageObjectSteps.Helpers.Configuration;
using PageObjectSteps.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSteps.Steps
{
    internal class NavigationSteps : BaseSteps
    {
        private LoginPage _loginPage;
        private IventoryPage _iventoryPage;
        private ProductCartPage _productCartPage;
        private CheckOutStepOnePage _checkOutStepOnePage;
        private CheckOutStepTwoPage _checkOutStepTwoPage;
        private CheckOutCompletePage _checkOutCompletePage;
        public NavigationSteps(IWebDriver driver) : base(driver)
        {
            _loginPage = new LoginPage(Driver);
            _iventoryPage = new IventoryPage(Driver, true);
            _productCartPage = new ProductCartPage(Driver, true);
            _checkOutStepOnePage = new CheckOutStepOnePage(Driver, true);
            _checkOutStepTwoPage = new CheckOutStepTwoPage(Driver, true);
            _checkOutCompletePage = new CheckOutCompletePage(Driver, true);

        }
        public IventoryPage SuccessfulLogin(string name, string pass)
        {
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.LoginInButton.Click();
            return new IventoryPage(Driver, true);
        }
        public LoginPage IncorrectLogin(string name, string pass)
        {
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.UserNameInput.SendKeys(pass);
            _loginPage.LoginInButton.Click();
            return _loginPage;
        }
        public ProductCartPage ClickShoppingCartLink()
        {
            _iventoryPage.ShoppingCartLink.Click();
            return new ProductCartPage(Driver, true);
        }
        public CheckOutStepOnePage ClickCheckoutbutton()
        {
            _productCartPage.CheckoutButton.Click();
            return new CheckOutStepOnePage(Driver, true);
        }

        public CheckOutStepTwoPage CheckInfo(string firstName, string lastName, string postCode)
        {
            _checkOutStepOnePage.FirstNameInput.SendKeys(firstName);
            _checkOutStepOnePage.LastNameInput.SendKeys(lastName);
            _checkOutStepOnePage.PostalCodeInput.SendKeys(postCode);
            _checkOutStepOnePage.ContinueButton.Click();
            return new CheckOutStepTwoPage(Driver, true);
        }
        public CheckOutCompletePage ClickFinishButton()
        {
            _checkOutStepTwoPage.FinishButton.Click();
            return new CheckOutCompletePage(Driver, true);
        }

        public IventoryPage ReturnHomePage()
        {
            _checkOutCompletePage.BackHomeButton.Click();
            return new IventoryPage(Driver, true);
        }
    }
}
