using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data
{
    public class EMContext: DbContext
    {
        public EMContext(DbContextOptions<EMContext> options) : base(options){}
        public DbSet<Employee> Employees {get; set; }
    }
    
}
