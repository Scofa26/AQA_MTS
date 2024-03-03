using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using PageObjectStepsHW.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Steps
{
    internal class NavigationSteps : BaseSteps
    {
        public NavigationSteps(IWebDriver driver) : base(driver)
        {
           
        }

        [AllureStep("Open IventoryPage after successful log in ")]
        public IventoryPage SuccessfulLogin(string name, string pass)
        {
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.PswInput.SendKeys(pass);
            _loginPage.LoginInButton.Click();
            return new IventoryPage(Driver, true);
        }

        [AllureStep("Check error for incorrect login")]
        public LoginPage IncorrectLogin(string name, string pass)
        {
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.PswInput.SendKeys(pass);
            _loginPage.LoginInButton.Click();
            return _loginPage;
        }

        [AllureStep("Open ProductCartPage")]
        public ProductCartPage ClickShoppingCartLink()
        {
            _iventoryPage.ShoppingCartLink.Click();
            return new ProductCartPage(Driver, true);
        }

        [AllureStep("Open CheckOutStepOnePage")]
        public CheckOutStepOnePage ClickCheckoutbutton()
        {
            _productCartPage.CheckoutButton.Click();
            return new CheckOutStepOnePage(Driver, true);
        }

        [AllureStep]
        public CheckOutStepTwoPage CheckInfo(string firstName, string lastName, string postCode)
        {
            _checkOutStepOnePage.FirstNameInput.SendKeys(firstName);
            _checkOutStepOnePage.LastNameInput.SendKeys(lastName);
            _checkOutStepOnePage.PostalCodeInput.SendKeys(postCode);
            _checkOutStepOnePage.ContinueButton.Click();
            return new CheckOutStepTwoPage(Driver, true);
        }

        [AllureStep("Open CheckOutCompletePage")]
        public CheckOutCompletePage ClickFinishButton()
        {
            _checkOutStepTwoPage.FinishButton.Click();
            return new CheckOutCompletePage(Driver, true);
        }

        [AllureStep("Return to homepage")]
        public IventoryPage ReturnHomePage()
        {
            _checkOutCompletePage.BackHomeButton.Click();
            return new IventoryPage(Driver, true);
        }
    }
}
