using OpenQA.Selenium;
using PageObjectSteps.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSimple.Pages
{
    internal class MenuPage : BasePage
    {
        private static string END_POINT = "";
        // Описание элементов
        private static readonly By WorkingOnMenuBy = By.Id("inProgressLink");

        public MenuPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return WorkingOnMenu.Displayed;
        }

        // Методы
        public IWebElement WorkingOnMenu => WaitHelpers.WaitForExists(WorkingOnMenuBy);
    }
}
