using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class DepartureAirport
{
    public int FlightId { get; set; }

    public int AirportId { get; set; }

    public virtual AirportConstruction Airport { get; set; } = null!;

    public virtual Flight Flight { get; set; } = null!;
}
