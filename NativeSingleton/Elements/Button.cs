using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeSingleton.Elements
{
    internal class Button
    {
        private UIElement _uiElement;

        public Button( By by)
        {
            _uiElement = new UIElement(by);
        }

        public Button(IWebElement webElement)
        {
            _uiElement = new UIElement(webElement);
        }

        public void Click()
        {
            _uiElement.Click();
        }

        public void Submit()
        {
            _uiElement.Submit();
        }

        public string Text => _uiElement.Text;
        public bool Displayed => _uiElement.Displayed;
    }
}
