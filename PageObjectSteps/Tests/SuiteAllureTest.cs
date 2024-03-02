using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Tests
{
    [AllureParentSuite("Web Interface")]
    [AllureSuite("Essential features")]
    internal class SuiteAllureTest : BaseTest
    {
        [Test]
        [AllureSubSuite("SubSuite 1")]
        public void SuiteTest()
        {
            Assert.That(true);
        }

        [Test]
        public void SuiteTest1()
        {
            AllureApi.AddParentSuite("Web Interface 1");
            AllureApi.AddSuite("Essential features 1");
            AllureApi.AddSubSuite("SubSuite 1");

            Assert.That(true);
        }
    }
}
