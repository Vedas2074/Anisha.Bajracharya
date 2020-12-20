using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Models;
using EmployeeManagement.Data;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
        
            var employees = Employee.GetEmployees();

            return View(employees);
        }
        public ActionResult Detail(int id)
        {
            var employees = Employee.GetEmployees();
            var emp = employees.FirstOrDefault(x => x.Id == id);
            return View(emp);

        }
        public ActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
         public string Add(Employee employee)
        {
            
            return "Record Saved";

        }  

        private readonly EMContext db;

        public EmployeeController(EMContext _db)
        {
            db = _db;
        }
    }
}