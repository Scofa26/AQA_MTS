using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvanced.Tests
{
    public class FileUpload : BaseTest
    {
        [Test]
        public void FileUploadTest()
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/upload");

            var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));

            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string filePath = Path.Combine(assemblyPath, "Resources", "picture.jpg");

            fileUploadElement.SendKeys(filePath);

            WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();

            Assert.Multiple(() =>
            {
                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//h3")).Text, Is.EqualTo("File Uploaded!"));
                Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("uploaded-files")).Text, Is.EqualTo("picture.jpg"));
            });
        }
    }
}
