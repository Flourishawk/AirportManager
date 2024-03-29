using Airport.Services.Interfaces;
using AirportManager.Models;

namespace AirportManager.Services.Implementations
{
    internal class AirportLocationService : IAirportLocationService
    {
        public void AddAirportLocation(AirportLocation airportLocation)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.AirportLocations.Any(e1 => e1.LocationId == airportLocation.LocationId);
            if (!checkIfExist)
            {
                db.AirportLocations.Add(airportLocation);
                db.SaveChanges();
            }
        }

        public void UpdateAirportLocation(AirportLocation airportLocationBeforeChanges, string country, string city, string latitude, string longtitude)
        {
            using AirportdbContext db = new();
            AirportLocation? airportLocation = db.AirportLocations.FirstOrDefault(a => a.LocationId == airportLocationBeforeChanges.LocationId);
            if (airportLocation != null)
            {
                airportLocation.Country = country;
                airportLocation.City = city;
                airportLocation.Latitude = latitude;
                airportLocation.Longtitude = longtitude;
            }
            db.SaveChanges();
        }

        public void DeleteAirportLocation(AirportLocation airportLocation)
        {
            using AirportdbContext db = new();
            db.AirportLocations.Remove(airportLocation);
            db.SaveChanges();
        }

        public List<AirportLocation> GetAllAirportLocations()
        {
            using AirportdbContext db = new();
            var allAirportLocations = db.AirportLocations.ToList();
            return allAirportLocations;
        }
    }
}
