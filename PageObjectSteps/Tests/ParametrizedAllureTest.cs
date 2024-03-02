using Allure.Net.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allure.Tests
{
    internal class ParametrizedAllureTest : BaseTest
    {
        [TestCase("johndoe", "qwerty")]
        [TestCase("johndoe@example.com", "qwerty")]
        public void TestCreateLabel(string login, string password)
        {
            Assert.That(true);
        }

        [Test]
        public void TestAuthenticationWithUsername()
        {
            AllureApi.AddTestParameter("login", "johndoe");
            AllureApi.AddTestParameter("password", "qwerty", ParameterMode.Masked);

            Assert.That(true);
        }

        [Test]
        public void TestAuthenticationWithEmail()
        {
            AllureApi.AddTestParameter("login", "johndoe@example.com");
            AllureApi.AddTestParameter("password", "qwerty", ParameterMode.Masked);

            Assert.That(true);
        }
    }
}
