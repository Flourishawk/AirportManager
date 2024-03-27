using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
