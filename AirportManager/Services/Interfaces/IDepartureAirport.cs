using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IDepartureAirport
    {
        List<Flight> GetAlFlight();
        void AddFlight(Flight flight);
        void UpdateFlight(Flight flight, DateTime departureTime, DateTime arrivalTime, int airlineId);
        void DeleteFlight(Flight flight);
    }
}
