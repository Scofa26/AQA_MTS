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
    internal class DropDown
    {
        private List<UIElement> _uiElements;
        public List<string> _values;
        public List<string> _texts;

        public DropDown(IWebDriver webDriver, By by)
        {
            _uiElements = new List<UIElement>();
            _texts = new List<string>();
            _values = new List<string>();
            WaitHelpers waitHelpers = new WaitHelpers(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

            foreach (var webElement in waitHelpers.PresenceOfAllElementsLocatedBy(by))
            {
                UIElement uIElement = new UIElement(webDriver, webElement);
                _uiElements.Add(uIElement);
                _values.Add(uIElement.GetAttribute("id"));
                // _texts.Add(uIElement.FindUIElement(By.XPath("child::*")).Text.Trim());
                _texts.Add(uIElement.Text.Trim());
            }

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
    }
}
