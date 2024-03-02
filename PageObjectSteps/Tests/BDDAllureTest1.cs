using Allure.Net.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Tests
{
    internal class BDDAllureTest1 : BaseTest
    {
        [Test]
        public void Story3Test()
        {
            AllureApi.AddEpic("Web Interface");
            AllureApi.AddFeature("Essential feature");
            AllureApi.AddFeature("Integration feature");
            AllureApi.AddStory("Story3");

            Assert.That(true);
        }
    }
}
