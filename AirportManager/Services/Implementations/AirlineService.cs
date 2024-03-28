using AirportManager.Models;
using Airport.Services.Interfaces;
using System.Linq;

namespace Airport.Services.Implementations
{
    internal class AirlineService
    {
        public void AddAirline(Airline airlane)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Airlines.Any(e1 => e1.AirlineId == airlane.AirlineId);
            if (!checkIfExist)
            {
                db.Airlines.Add(airlane);
                db.SaveChanges();

            }
        }

        public void UpdateAirline(Airline airlaneBeforeChanges, string description)
        {
            using AirportdbContext db = new();
            Airline? airline = db.Airlines.FirstOrDefault(a => a.AirlineId == airlaneBeforeChanges.AirlineId);
            if (airline != null)
            {
                airline.Description = description;
            }
            db.SaveChanges();
        }

        public void DeleteAirline(Airline airlane)
        {
            using AirportdbContext db = new();
            db.Airlines.Remove(airlane);
            db.SaveChanges();
        }

        public List<Airline> GetAllAirlines()
        {
            using AirportdbContext db = new();
            var allAirport = db.Airlines.ToList();
            return allAirport;
        }
    }
}
