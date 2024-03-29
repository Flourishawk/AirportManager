namespace AirportManager.Models;

public partial class Flight
{
    public int FlightId { get; set; }

    public DateTime DepartureTime { get; set; }

    public DateTime ArrivalTime { get; set; }

    public int AirlineId { get; set; }

    public virtual Airline Airline { get; set; } = null!;

    public virtual ICollection<ArrivalAirport> ArrivalAirports { get; set; } = new List<ArrivalAirport>();

    public virtual ICollection<DepartureAirport> DepartureAirports { get; set; } = new List<DepartureAirport>();
}
