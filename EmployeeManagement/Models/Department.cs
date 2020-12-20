using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EmployeeManagement.Models
{
    public class Department
    {
        public int Id {get; set;}

        [Required(ErrorMessage="We need your department name")]
        public string DepartmentName {get;  set;}
        public float Salary { get; set;}
        public static List<Department> GetDepartments()
        {
            Department department1 = new Department()
            {
                Id = 1,
                DepartmentName = "IT",
                Salary = 1546312
            };
            
            Department department2 = new Department()
            {
                Id = 2,
                DepartmentName = "Developer",
                Salary = 6312155
            };
            List<Department> departments =  new List<Department>() {department1, department2};
            return departments;
        }

    }
}