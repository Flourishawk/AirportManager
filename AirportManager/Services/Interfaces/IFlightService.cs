using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IFlightService
    {
        List<Flight> GetAllFlight();
        void AddFlight(Flight flight);
        void UpdateFlight(Flight flight, DateTime departureTime, DateTime arrivalTime, int airlineId);
        void DeleteFlight(Flight flight);
    }
}
