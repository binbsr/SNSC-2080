using HRM.Data;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    HRMContext db = new();

    [HttpGet]
    public IActionResult Index()
    {
        // Fetch all employees from db        
        var employees = db.Employees.ToList();

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
        db.Employees.Add(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        // Save employee to db
        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee employee)
    {
        // Save employee to db
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

}
