using BlazorWebAssemblyTutorial.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Server.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<EmployeeDataResult> GetEmployees(int skip, int take);
        Task<Employee> GetEmployee(int empployeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee empployee);
        Task<Employee> UpdateEmployee(Employee empployee);
        Task DeleteEmployee(int empployeeId);
    }
}
