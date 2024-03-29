using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IDepartureAirport
    {
        List<DepartureAirport> GetAllDepartureAirport();
        void AddDepartureAirport(DepartureAirport departureAirport);
        void UpdateDepartureAirport(DepartureAirport departureAirportBeforeChanges, );
        void DeleteDepartureAirport(DepartureAirport departureAirport);
    }
}
