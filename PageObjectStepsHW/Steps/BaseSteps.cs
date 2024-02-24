using OpenQA.Selenium;
using PageObjectStepsHW.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Steps
{
    internal class BaseSteps
    {
        protected IWebDriver Driver;
        public LoginPage _loginPage => new LoginPage(Driver);
        public IventoryPage _iventoryPage => new IventoryPage(Driver, true);
        public ProductCartPage _productCartPage => new ProductCartPage(Driver, true);
        public CheckOutStepOnePage _checkOutStepOnePage => new CheckOutStepOnePage(Driver, true);
        public CheckOutStepTwoPage _checkOutStepTwoPage => new CheckOutStepTwoPage(Driver, true);
        public CheckOutCompletePage _checkOutCompletePage => new CheckOutCompletePage(Driver, true);
        public BaseSteps(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
