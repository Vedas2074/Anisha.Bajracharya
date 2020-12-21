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
        
            var employees = db.Employees.ToList();
            return View(employees);
        }
        
        public IActionResult Detail(int id)
        {
        
            var employees = db.Employees.Find(id);

            return View(employees);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Update(employee);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        // public ActionResult Detail(int id)
        // {
        //     var employees = Employee.GetEmployees();
        //     var emp = employees.FirstOrDefault(x => x.Id == id);
        //     return View(emp);

        // }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(Employee employee)
        {
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");

        }  
        
        private readonly EMContext db;

        public EmployeeController(EMContext _db)
        {
            db = _db;
        }
    
    }
}