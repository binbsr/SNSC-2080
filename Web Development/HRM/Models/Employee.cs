using HRM.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set; }
    
    [DisplayName("Full Name")]
    public string Name { get; set; }

    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public Gender Gender { get; set; }

    [DisplayName("Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }

    [DisplayName("Join Date")]
    [DataType(DataType.Date)]
    public DateTime JoinDate { get; set; }

    public Designation? Designation { get; set; }

    [DisplayName("Designation")]
    public int DesignationId { get; set; }
}
