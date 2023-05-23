using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Name = "Bishnu Rawal",
                Address = "Ktm",
                Email = "a@a.com",
                Phone = "379573983789",
                Gender = Gender.Male,
                Dob = DateTime.Now,
                JoinDate = DateTime.Now
            },
            new Employee
            {
                Name = "Bishnu Rawal",
                Address = "Ktm",
                Email = "a@a.com",
                Phone = "379573983789",
                Gender = Gender.Male,
                Dob = DateTime.Now,
                JoinDate = DateTime.Now
            },
            new Employee
            {
                Name = "Bishnu Rawal",
                Address = "Ktm",
                Email = "a@a.com",
                Phone = "379573983789",
                Gender = Gender.Male,
                Dob = DateTime.Now,
                JoinDate = DateTime.Now
            }
        };

        return View(employees);
    }
}
