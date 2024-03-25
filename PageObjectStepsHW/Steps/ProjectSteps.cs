using OpenQA.Selenium;
using PageObjectStepsHW.Pages;
using PageObjectStepsHW.Pages.ProjectPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Steps
{
    internal class ProjectSteps : BaseSteps
    {
        public ProjectSteps(IWebDriver driver) : base(driver)
        {
            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            DashboardPage dashboardPage = new DashboardPage(Driver);
        }

        public void AddProductToCart(List<string> Products)
        {
            new NavigationSteps(Driver).NavigateToProducts();


            // Пройтись по всей коллекции и найти эелементы на странице
            // Нажать кнопку Добавить для каждого элемента
        }

        public void CreateProject()
        {

        }

        public void UpdateProject()
        {

        }

        public void ReadProject()
        {

        }

        public void DeleteProject()
        {

        }
    }
}
