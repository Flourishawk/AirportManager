using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Capacity
{
    public int CapacityId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();
}
