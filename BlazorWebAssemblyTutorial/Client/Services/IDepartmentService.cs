
using BlazorWebAssemblyTutorial.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Client.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
