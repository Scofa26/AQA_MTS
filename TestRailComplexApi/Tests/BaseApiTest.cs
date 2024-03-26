using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Services;

namespace TestRailComplexApi.Tests
{
    public class BaseApiTest
    {
        protected ProjectService? ProjectService;

        [OneTimeSetUp]
        public void SetupApi()
        {
            var restClient = new RestClientExtended();
            ProjectService = new ProjectService(restClient);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            ProjectService?.Dispose();  
        }
    }
}
