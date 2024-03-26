using AngleSharp.Io;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services
{
    public class ProjectService : IProjectService
    {
        private readonly RestClientExtended _client;

        public ProjectService(RestClientExtended client) 
        {
            _client = client;
        }

        public Task<Project> AddProject(Project project)
        {
            var request = new RestRequest("index.php?/api/v2/add_project", Method.Post)
                .AddJsonBody(project) ;

            return _client.ExecuteAsync<Project>(request);
        }

        public HttpStatusCode DeleteProject(string projectId)
        {
            var request = new RestRequest("index.php?/api/v2/delete_project/{project_id}", Method.Post)
            .AddUrlSegment("project_id", projectId)
            .AddJsonBody("{}");

            return _client.ExecuteAsync(request).Result.StatusCode;
        }

        public Task<Project> GetProject(string projectId)
        {
            var request = new RestRequest("index.php?/api/v2/get_project/{project_id}")
                .AddUrlSegment("project_id", projectId);

            return _client.ExecuteAsync<Project>(request);  

        }

        public Task<Projects> GetProjects()
        {

            var request = new RestRequest("index.php?/api/v2/get_projects");

            return _client.ExecuteAsync<Projects>(request);
        }

        public Task<Project> UpdateProject(Project project)
        {
            var request = new RestRequest("index.php?/api/v2/update_project/{project_id}", Method.Post)
           .AddUrlSegment("project_id", project.Id)
           .AddJsonBody(project);

            return _client.ExecuteAsync<Project>(request);
        }
        
        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
