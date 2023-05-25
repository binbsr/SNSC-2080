using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id= 1,
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
                Id= 2,
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
                Id= 3,
                Name = "Bishnu Rawal",
                Address = "Ktm",
                Email = "a@a.com",
                Phone = "379573983789",
                Gender = Gender.Male,
                Dob = DateTime.Now,
                JoinDate = DateTime.Now
            }
        };

    [HttpGet]
    public IActionResult Index()
    {
        return View(employees);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        // Save employee to db
        employees.Add(employee);

        return RedirectToAction("Index");
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        var employee = employees.Find(x => x.Id == id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        // Save employee to db
        employees.Add(employee);

        return RedirectToAction("Index");
    }

}
