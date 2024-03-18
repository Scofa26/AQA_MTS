using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Steps;

namespace BuilderPattern.Tests
{
    internal class ProjectTest : BaseTest
    {
        [Test]
        public void SuccessfulAddProjectTest()
        {
            _navigationSteps.SuccessfulLogin(Admin);

            Project expectedProject = new Project.Builder()
                .SetProjectName("WP Test 01")
                .SetAnnouncement("Test Details")
                .SetShowAnnouncement(false)
                .SetProjectType(1)
                .Build();

            Assert.That(_projectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
                Is.EqualTo("Successfully added the new project."));
        }
    }
}
