using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirportLocation
    {
        List<AirportLocation> GetAllAirportLocation();
        void AddAirportLocation(AirportLocation airportConstruction);
        void UpdateAirportLocation(AirportLocation airportConstructionBeforeChanges, string country, string city, string latitude, string longtitude);
        void DeleteAirportLocation(AirportLocation airportConstruction);
    }
}
