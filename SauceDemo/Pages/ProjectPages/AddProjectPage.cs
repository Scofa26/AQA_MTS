﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectSimple.Pages.ProjectPages
{
    internal class AddProjectPage : ProjectBasePage
    {
        private static string END_POINT = "index.php?/admin/projects/add";
        private static readonly By AddButtonBy = By.Id("name");

        public AddProjectPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }
        public IWebElement AddButton => Driver.FindElement(AddButtonBy);
    }
}
