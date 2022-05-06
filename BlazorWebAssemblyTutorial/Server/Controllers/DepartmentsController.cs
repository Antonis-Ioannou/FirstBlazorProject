using BlazorWebAssemblyTutorial.Server.Models;
using BlazorWebAssemblyTutorial.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController :ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentsController(DepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await departmentRepository.GetDepartments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
            }
        }

        [HttpGet("{departmentId:int}")]
        public async Task<ActionResult> GetDepartment(int departmentId)
        {
            try
            {
                var result = await departmentRepository.GetDepartment(departmentId);

                if (result == null)
                {
                    return NotFound();
                }

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
