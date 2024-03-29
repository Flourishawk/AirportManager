using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirportLocationService
    {
        List<AirportLocation> GetAllAirportLocations();
        void AddAirportLocation(AirportLocation airportLocation);
        void UpdateAirportLocation(AirportLocation airportLocationBeforeChanges, string country, string city, string latitude, string longtitude);
        void DeleteAirportLocation(AirportLocation airportLocation);
    }
}
