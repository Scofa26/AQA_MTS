using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Helpers.Configuration;
using ValueOfObjects.Pages;
using ValueOfObjects.Tests;

namespace ValueOfObjects.Tests
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void SuccessfulLoginTest()
        {
            Assert.That(_navigationSteps.SuccessfulLogin(Admin).SidebarProjectsAddButton.Displayed);
        }
    }
}
