using CMS_back.Data;
using CMS_back.Models;
using CMS_back.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_back.Services
{
    public class EmployeesService
    {
        private AppDbContext context;
        public EmployeesService(AppDbContext context)
        {
            this.context = context;
        }

        public void AddEmployee(EmployeeVM employee)
        {
            var newEmployee = new Employee()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Birthdate = employee.Birthdate,
                PhotoSrc = employee.PhotoSrc,
            };
            this.context.Employees.Add(newEmployee);
            this.context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return context.Employees.FirstOrDefault(_ => _.Id == id);
        }
    }
}
