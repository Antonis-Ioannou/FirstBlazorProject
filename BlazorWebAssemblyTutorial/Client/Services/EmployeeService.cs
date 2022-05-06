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
        public Task<Employee> AddEmployee(Employee empployee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int empployeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetEmployee(int empployeeId)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{empployeeId}");
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Employee>>("/api/employees");
        }

        public Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee empployee)
        {
            throw new NotImplementedException();
        }
    }
}
