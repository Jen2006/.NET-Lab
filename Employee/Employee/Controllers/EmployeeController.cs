using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Employee.Models;

namespace Employee.Controllers 
{   
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<emp> employees = new List<emp>()
            {
                new emp { Id = 1, Name = "Ravi", Department = "IT" },
                new emp { Id = 2, Name = "Anu", Department = "HR" }
            };

            return View(employees);
        }
    }
}
