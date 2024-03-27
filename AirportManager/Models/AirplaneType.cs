using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class AirplaneType
{
    public int AirplaneTypeId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();
}
