using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueOfObjects.Models;
using ValueOfObjects.Steps;

namespace ValueOfObjects.Tests
{
    internal class ProjectTest : BaseTest
    {
        [Test]
        public void SuccessfulAddProjectTest()
        {
            _navigationSteps.SuccessfulLogin(Admin);

            Project expectedProject = new Project()
            {
                ProjectName = "WP Test 01",
                Announcement = "Test Details",
                IsShowAnnouncement = false,
                ProjectType = 1
            };

            Assert.That(_projectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
                Is.EqualTo("Successfully added the new project."));
        }
    }
}
