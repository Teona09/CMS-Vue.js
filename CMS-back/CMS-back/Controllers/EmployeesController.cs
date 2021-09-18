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
            var employee = employeesService.GetEmployeeById(id);
            if(employee != null)
            {
                return Ok(employee);
            } else
            {
                return NotFound();
            }
        }

        [HttpPut("update-employee-by-id/{id}")]
        public IActionResult UpdateEmployeeById(int id,[FromBody]EmployeeVM employee)
        {
            var updatedEmployee = employeesService.UpdateEmployeeById(id, employee);
            return Ok(updatedEmployee);
        }

        [HttpDelete("delete-employee-by-id/{id}")]
        public IActionResult DeleteEmployeeById(int id)
        {
            employeesService.DeleteEmployeeById(id);
            return Ok();
        }
    }
}
