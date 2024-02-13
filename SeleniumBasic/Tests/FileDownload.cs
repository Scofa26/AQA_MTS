using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvanced.Core;
using SeleniumAdvanced.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.Tests
{
    public class FileDownload : BaseTest
    {
        [Test]  
        public void FileDownloadTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/download");
            string filePath = Path.Combine(DriverFactory.filePath, "some-file.txt", "some-file.txt");

            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists) fileInfo.Delete();

            Actions action = new Actions(Driver);
            action
                .Click(WaitsHelper.WaitForExists(By.LinkText("some-file.txt")))
                .Pause(TimeSpan.FromSeconds(3))
                .Build()
                .Perform();
            Assert.That(WaitsHelper.WaitForFileExists(fileInfo), Is.True);
        }
    }
}
