using CMS_back.Models;
using CMS_back.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeesDataService employeesDataService;

        public HomeController(ILogger<HomeController> logger, IEmployeesDataService employeesDataService)
        {
            _logger = logger;
            this.employeesDataService = new EmployeesDataService();
            employeesDataService.AddEmployee("Teona", "Tanasa", "teona@gmail.com", new DateTime(2000, 1, 9), "https://images.unsplash.com/photo-1508921912186-1d1a45ebb3c1?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGhvdG98ZW58MHx8MHx8&ixlib=rb-1.2.1&w=1000&q=80");

        }

        [HttpGet]
        public int GetCount()
        {
            return this.employeesDataService.GetEmployeeData().List.Count;
        }
        [HttpPost]
        public void AddEmployee(string fname, string lname, string email, DateTime birthdate, string photoSrc)
        {
            this.employeesDataService.AddEmployee(fname, lname, email, birthdate, photoSrc);
        }

        public IActionResult Index()
        {
            return View(this.employeesDataService.GetEmployeeData());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
