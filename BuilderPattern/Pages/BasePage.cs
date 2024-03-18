using BuilderPattern.Helpers;
using BuilderPattern.Helpers.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Pages
{
    internal abstract class BasePage : LoadableComponent<BasePage>
    {
        protected IWebDriver Driver { get; }
        protected WaitHelpers WaitsHelper { get; private set; }

        protected BasePage(IWebDriver driver, bool openByURL = false)
        {
            Driver = driver;
            WaitsHelper = new WaitHelpers(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

            if (openByURL) Load();
        }

        protected abstract string GetEndpoint();

        protected override void ExecuteLoad()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}
