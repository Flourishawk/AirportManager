using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IFlightService
    {
        List<Flight> GetAllFlights();
        void AddFlight(Flight flight);
        void UpdateFlight(Flight flightBeforeChanges, DateTime departureTime, DateTime arrivalTime, int airlineId);
        void DeleteFlight(Flight flight);
    }
}
