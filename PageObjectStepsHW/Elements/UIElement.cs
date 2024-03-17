﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjectStepsHW.Helpers.Configuration;
using PageObjectStepsHW.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;

namespace PageObjectStepsHW.Elements
{
    internal class UIElement : IWebElement
    {
        private IWebDriver _webDriver;
        private WaitHelpers _waitsHelper;
        private IWebElement _webElement;
        private Actions _actions;

        private UIElement(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _waitsHelper = new WaitHelpers(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            _actions = new Actions(webDriver);
        }

        public UIElement(IWebDriver webDriver, By by) : this(webDriver)
        {
            _webElement = _waitsHelper.WaitForExists(by);
        }

        public UIElement(IWebDriver webDriver, IWebElement webElement) : this(webDriver)
        {
            _webElement = webElement;
        }

        public string TagName => throw new NotImplementedException();

        public string Text
        {
            get
            {
               /* if(_webElement.Text.Equals(""))
                {
                    if (GetAttribute("value").Equals(""))
                    {
                        return _webElement.GetAttribute("innerText");
                    }
                    else return _webElement.GetAttribute("value");
                }*/
                return _webElement.Text;
            }
        }

        public bool Enabled => _webElement.Enabled;

        public bool Selected => _webElement.Selected;

        public Point Location => _webElement.Location;

        public Size Size => _webElement.Size;

        public bool Displayed => _webElement.Displayed;

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            try
            {
                _webElement.Click();
            }
            catch (ElementNotInteractableException)
            {
                try
                {
                    _actions
                        .MoveToElement(_webElement)
                        .Click()
                        .Build()
                        .Perform();
                }
                catch (Exception)
                {
                    MoveToElement();
                    ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].click();", _webElement);
                }
            }

        }
        /*
                public IWebElement FindElement(By by)
                {
                   return _webElement.FindElement(by);
                }*/

        public IWebElement FindElement(By by)
        {
            return _waitsHelper.WaitChildElement(_webElement, by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
           return _webElement.FindElements(by);
        }

        public UIElement FindUIElement(By by)
        {
            return new UIElement(_webDriver, FindElement(by));
        }
        public List<UIElement> FindUIElements(By by)
        {
            var result = new List<UIElement>();

            foreach(var webElement in FindElements(by))
            {
                result.Add(new UIElement(_webDriver, webElement));
            }
            return result;
        }

        public string GetAttribute(string attributeName)
        {
            return _webElement.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return _webElement.GetCssValue(propertyName);
        }

        public string GetDomAttribute(string attributeName)
        {
            return _webElement.GetAttribute(attributeName);
        }

        public string GetDomProperty(string propertyName)
        {
            return _webElement.GetDomProperty(propertyName);
        }

        public ISearchContext GetShadowRoot()
        {
            return _webElement.GetShadowRoot();
        }

        public void MoveToElement()
        {
            ((IJavaScriptExecutor)_webDriver).ExecuteScript("arguments[0].scrollIntoView(true);", _webElement);
        }
        public void SendKeys(string text)
        {
            _webElement.SendKeys(text);
        }

        public void Submit()
        {
            _webElement.Submit();
        }
        public void Hover()
        {
            _actions.MoveToElement(_webElement).Build().Perform();
        }
    }
}
