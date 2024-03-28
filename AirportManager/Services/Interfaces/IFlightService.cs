using AirportManager.Models;
using System.Windows.Media.Media3D;

namespace Airport.Services.Interfaces
{
    internal interface IFlightService
    {
        List<Flight> GetAlFlight();
        void AddFlight(Flight flight);
        void UpdateFlight(Flight flight, DateTime departureTime, DateTime arrivalTime, int airlineId);
        void DeleteFlight(Flight flight);
    }
}
