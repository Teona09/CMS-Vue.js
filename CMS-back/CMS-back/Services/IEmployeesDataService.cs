using CMS_back.Models;
using System;

namespace CMS_back.Services
{
    public interface IEmployeesDataService
    {
        int AddEmployee(string fname, string lname, string email, DateTime birthdate, string photoSrc);
        Employee GetEmployeeById(int id);
        void RemoveEmployee(int id);
        void UpdateMember(int elementId, string fname, string lname, string email, DateTime birthdate, string photoSrc);
    }
}