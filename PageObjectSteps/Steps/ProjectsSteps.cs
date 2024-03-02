using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Allure.Steps;
using Allure.Pages;
using Allure.Pages.ProjectPages;

namespace Allure.Steps
{
    internal class ProjectsSteps : BaseSteps
    {
        public ProjectsSteps(IWebDriver driver) : base(driver)
        {
            AddProjectPage addProjectPage = new AddProjectPage(Driver);
            DashboardPage dashboardPage = new DashboardPage(Driver);
        }

        public void AddProductToCart(List<string> Products)
        {
            //перейти на страницу
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
