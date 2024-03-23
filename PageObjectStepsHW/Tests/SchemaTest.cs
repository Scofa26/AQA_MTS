using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NLog;
using PageObjectStepsHW.Models;
using RestSharp.Authenticators;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Tests
{
    internal class SchemaTest
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private const string BaseRestUri = "https://aqa2504.testrail.io/";

        [Test]
        public void JsonSchemaTest()
        {
            const string endpoint = "index.php?/api/v2/add_project";

            Project expectedProject = new Project
            {
                Name = "WP Project 2",
                Announcement = "Test project description",
                IsShowAnnouncement = true,
                SuiteMode = 2
            };

            // Загрузка JSON-схемы из файла
            string schemaJson = File.ReadAllText(@"Resources/schema.json");

            // Создем экземпляр JSON-схемы
            JSchema schema = JSchema.Parse(schemaJson);

            var options = new RestClientOptions(BaseRestUri)
            {
                Authenticator = new HttpBasicAuthenticator("atrostyanko@gmail.com", "Qwertyu_1")
            };

            // Setup Rest Client
            var client = new RestClient(options);

            // Setup Request
            var request = new RestRequest(endpoint).AddJsonBody(expectedProject);

            // Execute Request
            var response = client.ExecutePost(request);

            // Проверяем статус ответа
            if (response.StatusCode == HttpStatusCode.OK)
            {
                // Получаем тело ответа в виде JObject
                JObject responseData = JObject.Parse(response.Content);

                // Проверка соответствия ответа JSON-схеме
                Assert.That(responseData.IsValid(schema));
            }
        }
    }
}
