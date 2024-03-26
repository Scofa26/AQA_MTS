using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Tests
{
    public class ProjectTest : BaseApiTest
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private Project _project = null;

        [Test]
        [Order(1)]
        public void AddTestProjectTest() 
        {
            _project = new Project
            {
                Name = "WP Test 1",
                Announcement = "Some description!!!",
                ShowAnnouncement = true,
                SuiteMode = 1
            };
            var actualProject = ProjectService!.AddProject(_project);

            Assert.That(actualProject.Result.Name.Equals("WP Test 1"));
        }

    }
}
