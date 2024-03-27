using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Airplane
{
    public int AirplaneId { get; set; }

    public int AirlineId { get; set; }

    public int AirplaneTypeId { get; set; }

    public int CapacityId { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual AirplaneType AirplaneType { get; set; } = null!;

    public virtual Capacity Capacity { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
