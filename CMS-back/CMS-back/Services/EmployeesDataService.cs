using CMS_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_back.Services
{
    public class EmployeesDataService : IEmployeesDataService
    {
        private readonly EmployeesData employeesData;

        public EmployeesDataService()
        {
            this.employeesData = new EmployeesData();
        }

        public Employee GetEmployeeById(int id)
        {
            foreach (Employee employee in employeesData.List)
            {
                if (employee.Id == id)
                {
                    return employee;
                }
            }

            return null;
        }

        public int AddEmployee(string fname, string lname, string email, DateTime birthdate, string photoSrc)
        {
            Employee newEmployee = new Employee(fname, lname, email, birthdate, photoSrc);
            this.employeesData.List.Add(newEmployee);
            return newEmployee.Id;
        }

        public void RemoveEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            this.employeesData.List.Remove(employee);
        }

        public void UpdateMember(int elementId, string fname, string lname, string email, DateTime birthdate, string photoSrc)
        {
            int index = employeesData.List.FindIndex(element => element.Id == elementId);
            employeesData.List[index].FirstName = fname;
            employeesData.List[index].LastName = lname;
            employeesData.List[index].Email = email;
            employeesData.List[index].Birthdate = birthdate;
            employeesData.List[index].PhotoSrc = photoSrc;
        }
    }
}
