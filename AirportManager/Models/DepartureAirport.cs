namespace AirportManager.Models
{
    public partial class DepartureAirport
    {
        public int FlightId { get; set; }

        public int AirportId { get; set; }

        public virtual Flight Flight { get; set; } = null!;

        public virtual AirportConstruction AirportConstruction { get; set; } = null!;
    }
}
