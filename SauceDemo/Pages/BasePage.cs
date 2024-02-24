using OpenQA.Selenium;
using PajeObjectSimple.Helpers;
using PajeObjectSimple.Helpers.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObjectSimple.Pages
{
    internal abstract class BasePage
    {
        protected IWebDriver Driver { get; private set; }
        protected WaitHelpers WaitHelpers { get; private set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            WaitHelpers = new WaitHelpers(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        }

        public BasePage(IWebDriver driver, bool openPageByUrl) : this(driver)
        {
            if(openPageByUrl)
            {
                OpenPageByURL();
            }
        }

        protected abstract string GetEndpoint();
        public abstract bool IsPageOpened();
        protected void OpenPageByURL()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + GetEndpoint());
        }
    }
}
