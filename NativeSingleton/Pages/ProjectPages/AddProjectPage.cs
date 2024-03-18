using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NativeSingleton.Elements;

namespace NativeSingleton.Pages.ProjectPages
{
    internal class AddProjectPage( bool openByURL = false) : ProjectBasePage( openByURL)
    {
        private const string END_POINT = "index.php?/admin/projects/add";

        // Описание элементов
        private static readonly By AddButtonBy = By.Id("accept");

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            return  WaitsHelper.WaitForVisibilityLocatedBy(AddButtonBy).Displayed;
        }

        // Атомарные Методы
        public Button AddButton => new Button( AddButtonBy);
    }
}
