using BlazorWebAssemblyTutorial.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<Employee> AddEmployee(Employee empployee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int empployeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int empployeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
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
