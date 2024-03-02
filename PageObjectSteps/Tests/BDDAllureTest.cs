using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Tests
{
    [AllureEpic("Web Interface")]
    [AllureFeature("Essential feature", "Integration feature")]
    internal class BDDAllureTest : BaseTest
    {
        [Test]
        [AllureStory("Story1")]
        public void Story1Test()
        {
            Assert.That(true);
        }

        [Test]
        [AllureStory("Story2")]
        public void Story2Test()
        {
            Assert.That(true);
        }

    }
}
