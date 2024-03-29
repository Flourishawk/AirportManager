using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirlineService
    {
        List<Airline> GetAllAirlines();
        void AddAirline(Airline airline);
        void UpdateAirline(Airline airlineBeforeChanges, string description);
        void DeleteAirline(Airline airline);
    }
}
