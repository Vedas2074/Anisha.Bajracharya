using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Models;
namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
        
            var departments = Department.GetDepartments();

            return View(departments);
        }
        public ActionResult Detail(int id)
        {
            var departments = Department.GetDepartments();
            var dept = departments.FirstOrDefault(x => x.Id == id);
            return View(dept);

        }
        //  public IActionResult Index()
        // {
        //     Department department1 = new Department()
        //     {
        //         Id = 1,
        //         DepartmentName = "IT",
        //         Salary = 1546312
        //     };
        //     Department department2 = new Department()
        //     {
        //         Id = 2,
        //         DepartmentName = "Developer",
        //         Salary = 6312155
        //     };
        //     List<Department> departments =  new List<Department>() {department1, department2};

        //     return View(departments);
        // }
        public ActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
         public string Add(Department department)
        {
            
            return "Record Saved";

        }  
    }
}