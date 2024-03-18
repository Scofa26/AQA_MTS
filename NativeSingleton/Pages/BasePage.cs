using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeSingleton.Helpers;
using NativeSingleton.Helpers.Configuration;
using OpenQA.Selenium.Support.UI;
using NativeSingleton.Core;

namespace NativeSingleton.Pages
{
    internal abstract class BasePage : LoadableComponent<BasePage>
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitsHelper WaitsHelper { get; private set; }

        public BasePage( bool openByURL = false)
        {
            Driver = BrowserSingleton.GetInstance().GetDriver();
            WaitsHelper = new WaitsHelper();
            if (openByURL) Load();
        }


        protected abstract string GetEndpoint();
        protected override void ExecuteLoad()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}
