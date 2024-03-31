using Airport.Services.Interfaces;
using AirportManager.Models;

namespace AirportManager.Services.Implementations
{
    internal class AirportConstructionService : IAirportConstructionService
    {
        public void AddAirportConstruction(AirportConstruction airportConstruction)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.AirportConstructions.Any(e1 => e1.AirportId == airportConstruction.AirportId);
            if (!checkIfExist)
            {
                db.AirportConstructions.Add(airportConstruction);
                db.SaveChanges();
            }
        }

        public void UpdateAirportConstruction(AirportConstruction airportConstructionBeforeChanges, int locationId, int airlineId)
        {
            using AirportdbContext db = new();
            AirportConstruction? airportConstruction = db.AirportConstructions.FirstOrDefault(a => a.AirportId == airportConstructionBeforeChanges.AirportId);
            if (airportConstruction != null)
            {
                airportConstruction.LocationId = locationId;
                airportConstruction.AirlineId = airlineId;
            }
            db.SaveChanges();
        }

        public void DeleteAirportConstruction(AirportConstruction airportConstruction)
        {
            using AirportdbContext db = new();
            db.AirportConstructions.Remove(airportConstruction);
            db.SaveChanges();
        }

        public List<AirportConstruction> GetAllAirportConstructions()
        {
            using AirportdbContext db = new();
            var allAirportConstructions = db.AirportConstructions.ToList();
            return allAirportConstructions;
        }

        public AirportConstruction GetAirportConstructionById(int airportConstructionId)
        {
            using AirportdbContext db = new();
            return db.AirportConstructions.FirstOrDefault(a => a.AirportId == airportConstructionId);
        }

    }
}
