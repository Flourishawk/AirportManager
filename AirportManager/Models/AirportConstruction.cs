using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class AirportConstruction
{
    public int AirportId { get; set; }

    public int LocationId { get; set; }

    public int AirlineId { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual AirportLocation Location { get; set; } = null!;

    public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();

    public virtual ICollection<Flight> FlightsNavigation { get; set; } = new List<Flight>();
}
