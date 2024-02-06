using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObjectSimple.Pages
{
    internal class LoginPage : BasePage
    {
        // Описание элементов
        private static readonly By EmailInputBy = By.Id("name");


        // Инициализация класса + переопределения
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        // Атомарные Методы
        public IWebElement EmailInput => Driver.FindElement(EmailInputBy);
    }
}
