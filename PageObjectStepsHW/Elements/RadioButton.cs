using OpenQA.Selenium;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Elements
{
    internal class RadioButton
    {
        /// <summary>
        /// Локатор данного элемента должен использовать атрибут name
        /// </summary>
        /// <param name="webDriver"></param>
        /// <param name="by"></param>
        /// 
        private List<UIElement> _uiElements;
        private List<String> _values;
        private List<string> _texts;

        public RadioButton(IWebDriver webDriver, By by)
        {
            _uiElements = new List<UIElement>();
            _values = new List<String>();
            _texts = new List<string>();


            WaitHelpers waitHelpers = new WaitHelpers(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            
           foreach(var webElement in waitHelpers.PresenceOfAllElementsLocatedBy(by))
            {
                UIElement uIElement = new UIElement(webDriver, webElement);
                _uiElements.Add(uIElement);
                _values.Add(uIElement.GetAttribute("value"));
                _texts.Add(uIElement.FindUIElement(By.XPath("parent::*/strong")).Text.Trim());

            }
        }
        public RadioButton(IWebDriver webDriver, IWebElement webElement)
        {
            
        }

        public void SelectByIndex(int index)
        {
            if (index < _uiElements.Count) _uiElements[index].Click();
            else throw new AssertionException("Превышен индекс");
        }

        public void SelectByValue(string value)
        {
            _uiElements[_values.IndexOf(value)].Click();
        }

        public void SelectByText(string text)
        {
            var index = _texts.IndexOf(text);
            _uiElements[index].Click();
        }
        public bool IsSelected(string value)
        {
            return _uiElements[_values.IndexOf(value)].Selected;
        }
        public List<string> GetOptions()
        {
            return _texts;
        }
    }
}
