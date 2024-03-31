using AirportManager.Models;
using Airport.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class AirlineService : IAirlineService
    {
        public void AddAirline(Airline airline)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Airlines.Any(e1 => e1.AirlineId == airline.AirlineId);
            if (!checkIfExist)
            {
                db.Airlines.Add(airline);
                db.SaveChanges();

            }
        }

        public void UpdateAirline(Airline airlineBeforeChanges, string description)
        {
            using AirportdbContext db = new();
            Airline? airline = db.Airlines.FirstOrDefault(a => a.AirlineId == airlineBeforeChanges.AirlineId);
            if (airline != null)
            {
                airline.Description = description;
            }
            db.SaveChanges();
        }

        public void DeleteAirline(Airline airline)
        {
            using AirportdbContext db = new();
            db.Airlines.Remove(airline);
            db.SaveChanges();
        }

        public List<Airline> GetAllAirlines()
        {
            using AirportdbContext db = new();
            var allAirlines = db.Airlines.ToList();
            return allAirlines;
        }
    }
}
