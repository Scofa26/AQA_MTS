﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeSingleton.Helpers;

namespace NativeSingleton.Pages.ProjectPages
{
    internal class ProjectPage(bool openByURL = false) : BasePage( openByURL)
    {
        private const string END_POINT = "index.php?/admin/projects/overview";

        // Описание элементов
        private static readonly By TitleBy = By.XPath("//*[contains(@class, 'page_title') and contains(text(), 'Projects')]");
        private static readonly By SuccessMessageBy = By.ClassName("message-success");

        protected override bool EvaluateLoadedStatus()
        {
            return Title.Displayed;
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public IWebElement Title => WaitsHelper.WaitForExists(TitleBy);
        public IWebElement SuccessMessage => WaitsHelper.WaitForExists(SuccessMessageBy);
    }
}
