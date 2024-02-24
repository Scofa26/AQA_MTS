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

        public IventoryPage SuccessfulLogin(string name, string pass)
        {
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.PswInput.SendKeys(pass);
            _loginPage.LoginInButton.Click();
            return new IventoryPage(Driver, true);
        }

        public LoginPage IncorrectLogin(string name, string pass)
        {
            _loginPage.UserNameInput.SendKeys(name);
            _loginPage.PswInput.SendKeys(pass);
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
