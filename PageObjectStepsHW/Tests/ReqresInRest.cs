using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Tests
{
    internal class ReqresInRest
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private const string BaseRestUri = "https://reqres.in";

        [Test]
        public void SimpleGetTest()
        {
            //const string endpoint = "/api/users/2"; // OK
            const string endpoint = "/api/users/23"; // 404 Not Found

            // Setup Rest Client
            var client = new RestClient(BaseRestUri);

            // Setup Request
            var request = new RestRequest(endpoint);

            // Execute Request
            var response = client.ExecuteGet(request);

            Logger.Info(response.Content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void SimplePostTest()
        {
            const string endpoint = "/api/users";

            // Setup Rest Client
            var client = new RestClient(BaseRestUri);

            // Setup Request
            var request = new RestRequest(endpoint);
            request.AddJsonBody("{\"name\": \"morpheus\",\"job\": \"leader\"}");

            // Execute Request
            var response = client.ExecutePost(request);

            Logger.Info(response.Content);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

    }
}
