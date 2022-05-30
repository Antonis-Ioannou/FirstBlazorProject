using BlazorWebAssemblyTutorial.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Client.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await httpClient.
                GetFromJsonAsync<IEnumerable<Department>>("/api/departments");
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await httpClient.GetFromJsonAsync<Department>($"api/departments/{departmentId}");
        }
    }
}
