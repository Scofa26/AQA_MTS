using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Tests
{
    
    internal class AllureTest : BaseTest
    {
        [Test(Description = "Описание")]
        public void TestDescription()
        {
            Assert.That(true);
        }

        [Test(Description = "Описание"),
            AllureSeverity(SeverityLevel.critical)]
        public void TesSeverity()
        {
            Assert.That(true);
        }

        [Test(Description = "Описание"),
            AllureOwner("Scofa")]
        public void TestOwner()
        {
            Assert.That(true);
        }

        [AllureIssue("Bug-123")]
        [AllureIssue("Bug-456")]
        [AllureTms("TMS-456")]
        public void TestIssue()
        {
            Assert.That(false);
        }

       
        [AllureLink("link","http://somelink.ru")]
        public void TestLink()
        {
            Assert.That(false);
        }

    }
}
