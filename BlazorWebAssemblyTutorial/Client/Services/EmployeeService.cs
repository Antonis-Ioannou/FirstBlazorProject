using BlazorWebAssemblyTutorial.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Employee> AddEmployee(Employee empployee)
        {
            var response = await httpClient.PostAsJsonAsync<Employee>("api/employees/",empployee);
            return await response.Content.ReadFromJsonAsync<Employee>();
        }

        public async Task DeleteEmployee(int empployeeId)
        {
            await httpClient.DeleteAsync($"api/employees/{empployeeId}");
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Employee>>("/api/employees/all");
        }

        public async Task<Employee> GetEmployee(int empployeeId)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{empployeeId}");
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDataResult> GetEmployees(int skip,int take, string orderBy)
        {
            return await httpClient.GetFromJsonAsync<EmployeeDataResult>($"/api/employees?skip={skip}&take={take}&orderBy={orderBy}");
        }

        public Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            throw new NotImplementedException();  
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var response = await httpClient.PutAsJsonAsync<Employee>($"/api/employees/{employee.EmployeeId}",employee);
            return await response.Content.ReadFromJsonAsync<Employee>();
        }
    }
}
