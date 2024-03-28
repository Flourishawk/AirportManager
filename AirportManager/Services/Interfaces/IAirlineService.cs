using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirlineService
    {
        List<Airline> GetAllAirlines();
        void AddAirline(Airline airlane);
        void UpdateAirline(Airline airlaneBeforeChanges, string description);
        void DeleteAirline(Airline airlane);
    }
}
