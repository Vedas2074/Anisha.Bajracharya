using System.Collections.Generic;
namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id {get;  set;}
        public string FirstName {get;  set;}
        public string LastName {get;  set;}
        public string Address {get;  set;}
        public byte Age {get;  set;}
        public float Salary { get; set;}
    public static List<Employee> GetEmployees()
            {
                Employee employee1 = new Employee()
                {
                    Id = 1,
                    FirstName = "Bishnu",
                    LastName = "Rawal",
                    Address = "Ktm",
                    Age = 12,
                    Salary = 1546312
                };
                Employee employee2 = new Employee()
                {
                    Id = 2,
                    FirstName = "Bishnu2",
                    LastName = "Rawal2",
                    Address = "Bhkt",
                    Age = 18,
                    Salary = 6312155
                };
                List<Employee> employees = new List<Employee>() {employee1,employee2};
                return employees;
            }
    }
}