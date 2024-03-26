using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services
{
    public  interface IProjectService
    {
        Task<Project> GetProject(string projectId);
        Task<Projects> GetProjects();
        Task<Project> AddProject(Project project);
        Task<Project> UpdateProject(Project project);
        HttpStatusCode DeleteProject(string projectId);
    }
}
