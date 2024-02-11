using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SeleniumAdvanced.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.Tests
{
    internal class ActionsTest : BaseTest
    {
        [Test]
        public void HoverTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/hovers");

            var actions = new Actions(Driver);

            var targetElements = WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.CssSelector(".figure"));
            actions
                .MoveToElement(targetElements[0], 50, 50)
                .Click(WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("[href='/users/1']")))
                .Build()
                .Perform();

            Assert.That(WaitsHelper.WaitForElementInvisible(targetElements[0]));
        }

        [Test]
        public void DragAndDropTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/drag_and_drop");

            var actions = new Actions(Driver);

            var targetElementA = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-a"));
            var targetElementB = WaitsHelper.WaitForVisibilityLocatedBy(By.Id("column-b"));

            actions
                .DragAndDrop(targetElementA, targetElementB)
                .Pause(TimeSpan.FromSeconds(3))
                .Build()
                .Perform();
        }

        [Test]
        public void CheckboxTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");

            var actions = new Actions(Driver);

            var targetElementA = WaitsHelper.WaitForVisibilityLocatedBy(By.CssSelector("#checkboxes input"));

            actions
                .MoveToElement(targetElementA)
                .Click()
                .Pause(TimeSpan.FromSeconds(3))
                .Build()
                .Perform();
        }

        [Test]
        public void FileUploadTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));

            // Получаем путь к исполняемому файлу (exe)
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Конструируем путь к файлу внутри проекта
            string filePath = Path.Combine(assemblyPath, "Resources", "1 1.png");

            fileUploadElement.SendKeys(filePath);

            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();

            Thread.Sleep(5000);
        }
    }
}
