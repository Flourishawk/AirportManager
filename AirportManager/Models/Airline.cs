using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Airline
{
    public int AirlineId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Airplane> Airplanes { get; set; } = new List<Airplane>();

    public virtual ICollection<AirportConstruction> AirportConstructions { get; set; } = new List<AirportConstruction>();

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
}
