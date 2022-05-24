using BlazorWebAssemblyTutorial.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Client.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<EmployeeDataResult> GetEmployees(int skip, int take, string orderBy);
        Task<Employee> GetEmployee(int empployeeId);
        Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee empployee);
        Task<Employee> UpdateEmployee(Employee empployee);
        Task DeleteEmployee(int empployeeId);
    }
}
