using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadableComponent.Helpers;
using LoadableComponent.Helpers.Configuration;
using LoadableComponent.Pages;
using OpenQA.Selenium.Support.UI;

namespace LoadableComponent.Pages
{
    internal abstract class BasePage : LoadableComponent<BasePage>
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitHelpers WaitHelpers { get; private set; }

        public BasePage(IWebDriver driver, bool openByURL = false)
        {
            Driver = driver;
            WaitHelpers = new WaitHelpers(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            if (openByURL) Load();
        }
        

        protected abstract string GetEndpoint();
        protected override void ExecuteLoad()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}
