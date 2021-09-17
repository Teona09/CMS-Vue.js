using CMS_back.Services;
using CMS_back.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesService employeesService;

        public EmployeesController(EmployeesService employeesService)
        {
            this.employeesService = employeesService;
        }

        [HttpPost("add-employee")]
        public IActionResult AddEmployee([FromBody] EmployeeVM employee)
        {
            employeesService.AddEmployee(employee);
            return Ok();
        }

        [HttpGet("get-all-employees")]
        public IActionResult GetAllEmployees()
        {
            return Ok(employeesService.GetAllEmployees());
        }

        [HttpGet("get-employee-by-id/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(employeesService.GetEmployeeById(id));
        }
    }
}
