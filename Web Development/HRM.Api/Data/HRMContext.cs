using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Api.Data;
public class HRMContext: DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SNSC_HRM_2080;Integrated Security=True;");
    }
}
