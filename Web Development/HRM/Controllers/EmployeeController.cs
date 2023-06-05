using HRM.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class EmployeeController : Controller
{
    HRMContext db = new();

    [HttpGet]
    public IActionResult Index()
    {
        // Fetch all employees from db        
        var employees = db.Employees.Include(x => x.Designation).ToList();

        return View(employees);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var designations = db.Designations.ToList();
        var designationList = designations.Select(x => new SelectListItem { Text = x.Title, Value = x.Id.ToString() });
        ViewData["DesignationList"] = designationList;

        var departments = db.Departments.ToList();
        ViewData["DepartmentList"] = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        
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
        //id = id + ";drop table employee;";        
        //var sql = "delete from employee where id="+id;

        // Save employee to db
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

}
