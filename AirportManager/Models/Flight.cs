using System;
using System.Collections.Generic;

namespace AirportManager.Models;

public partial class Flight
{
    public int FlightId { get; set; }

    public DateTime DepartureTime { get; set; }

    public DateTime ArrivalTime { get; set; }

    public int AirlineId { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual ArrivalAirport? ArrivalAirport { get; set; }

    public virtual DepartureAirport? DepartureAirport { get; set; }
}
