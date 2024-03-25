using OpenQA.Selenium;
using PageObjectStepsHW.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Pages.TestCasePages
{
    internal class TestCaseBasePage : BasePage
    {
        private static string END_POINT;
        private static readonly By AddTestCaseButtonBy = By.XPath("//a[contains(text(),'Add Test Case')]");
        private static readonly By TestcaseDropDownBy = By.ClassName("chzn-results");

        public TestCaseBasePage(IWebDriver driver) : base(driver)
        {
            END_POINT = driver.Url;
        }

        public TestCaseBasePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        // Атомарные Методы
        public DropDown TestcaseDropDown => new DropDown(Driver, TestcaseDropDownBy);
        public Button AddTestCaseButton => new Button(Driver, AddTestCaseButtonBy);
    }
}
