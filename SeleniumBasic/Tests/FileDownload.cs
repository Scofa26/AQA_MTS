using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
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
            FileInfo fileInfo = new FileInfo(@"C:\tmp\some-file.txt");
            if (fileInfo.Exists) fileInfo.Delete();

            Actions action = new Actions(Driver);
            action
                .Click(WaitsHelper.WaitForExists(By.LinkText("some-file.txt")))
                .Pause(TimeSpan.FromSeconds(3))
                .Build()
                .Perform();

            Assert.Multiple(() =>
            {
                Assert.That(fileInfo.Exists, Is.True);
                Assert.That(fileInfo.Name, Is.EqualTo("some-file.txt"));
            });
        }
    }
}
