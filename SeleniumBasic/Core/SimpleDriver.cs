using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasic.Core
{
    internal class SimpleDriver
    {
        public IWebDriver Driver
        {
            get
            {
                var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                //string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                // return new ChromeDriver(@"C:\Users\Scofa\source\repos\AQA_MTS\SeleniumBasic\Recources\chromedriver.exe");
               //  return new ChromeDriver(path + @"\Recources\");
                 return new ChromeDriver(basePath + @"\Recources\");
              
            }
        }
    }
}
