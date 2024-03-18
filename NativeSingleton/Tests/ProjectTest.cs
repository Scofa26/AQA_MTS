using NativeSingleton.Models;
using NativeSingleton.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeSingleton.Tests
{
    [TestFixture]
    internal class ProjectTest : BaseTest
    {
        /*[Test]
        public void SuccessfulAddProjectTest()
        {
            Project expectedProject = new Project()
            {
                ProjectName = "WP Test 01",
                Announcement = "Test Details",
                IsShowAnnouncement = false,
                ProjectType = 1
            };

            Assert.That(ProjectsSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
                Is.EqualTo("Successfully added the new project."));
        }*/
    }
}
