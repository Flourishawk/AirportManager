using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public decimal Salary { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int AirplaneId { get; set; }

    public int DepartmentId { get; set; }

    public virtual Airplane Airplane { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Human> Humans { get; set; } = new List<Human>();
}
