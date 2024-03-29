using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class AirportConstruction
{
    public int AirportId { get; set; }

    public int LocationId { get; set; }

    public int AirlineId { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual ICollection<ArrivalAirport> ArrivalAirports { get; set; } = new List<ArrivalAirport>();

    public virtual ICollection<DepartureAirport> DepartureAirports { get; set; } = new List<DepartureAirport>();

    public virtual AirportLocation Location { get; set; } = null!;
}
