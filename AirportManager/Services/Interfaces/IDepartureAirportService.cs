using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IDepartureAirportService
    {
        List<DepartureAirport> GetAllDepartureAirports();
        void AddDepartureAirport(DepartureAirport departureAirport);
        void UpdateDepartureAirport(DepartureAirport departureAirportBeforeChanges, int flightId, int airportId);
        void DeleteDepartureAirport(DepartureAirport departureAirport);
    }
}
