using HRM.Api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Api.Controllers;

[Route("api/employees")]
[ApiController]
public class EmployeesController : ControllerBase
{
    HRMContext db = new();

    [HttpGet]
    public List<Employee> Get()
    {
        var employees = db.Employees.ToList();
        return employees;
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var employee = db.Employees.Find(id);
        
        if (employee == null)
        {
            return NotFound();
        }

        return Ok(employee);
    }

    [HttpPost]
    public IActionResult Post(Employee employee)
    {
        db.Employees.Add(employee);
        db.SaveChanges();

        return Ok();
    }
}
