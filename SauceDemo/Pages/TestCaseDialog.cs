using OpenQA.Selenium;
using PajeObjectSimple.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSimple.Pages
{
    internal class TestCaseDialog : BasePage
    {
        public TestCaseDialog(IWebDriver driver) : base(driver)
        {
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override string GetEndpoint()
        {
            throw new NotImplementedException();
        }
    }
}
