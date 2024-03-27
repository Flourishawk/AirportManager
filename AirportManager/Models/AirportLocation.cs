using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class AirportLocation
{
    public int LocationId { get; set; }

    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Latitude { get; set; } = null!;

    public string Longtitude { get; set; } = null!;

    public virtual ICollection<AirportConstruction> AirportConstructions { get; set; } = new List<AirportConstruction>();
}
