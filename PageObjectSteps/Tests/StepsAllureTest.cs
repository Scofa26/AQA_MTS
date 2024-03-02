using Allure.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Tests
{
    internal class StepsAllureTest : BaseTest
    {
        [Test]
        public void TestCreateLabel()
        {
            AllureSteps.TestDomain("https://domain1.example.com/");
            AllureSteps.TestDomain("https://domain2.example.com/");
        }
    }
}
