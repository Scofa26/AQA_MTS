using OpenQA.Selenium;
using PageObjectStepsHW.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Pages.TestCasePages
{
    internal class AddTestCasePage : TestCaseBasePage
    {
        private static string END_POINT;

        // Описание элементов
        private static readonly By TestCaseDropDwnOpenBy = By.XPath("//span[text()='Test Case (Text)']");
        private static readonly By DropDownTestCaseBy = By.ClassName("active-result");

        public AddTestCasePage(IWebDriver driver) : base(driver)
        {
            END_POINT = driver.Url;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        // Атомарные Методы
        public Button TestCaseDropDwnOpen => new Button(Driver, TestCaseDropDwnOpenBy);
        public DropDown DropDownTestCase => new DropDown(Driver, DropDownTestCaseBy);

    }
}
