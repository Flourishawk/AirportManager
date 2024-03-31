using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class DepartureAirportService : IDepartureAirportService
    {
        public void AddDepartureAirport(DepartureAirport departureAirport)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.DepartureAirports.Any(e1 => e1.AirportId == departureAirport.AirportId && e1.FlightId == departureAirport.FlightId);
            if (!checkIfExist)
            {
                db.DepartureAirports.Add(departureAirport);
                db.SaveChanges();
            }
        }

        public void UpdateDepartureAirport(DepartureAirport departureAirportBeforeChanges, int flightId, int airportId)
        {
            using AirportdbContext db = new();
            DepartureAirport? departureAirport = db.DepartureAirports.FirstOrDefault(a => a.AirportId == departureAirportBeforeChanges.AirportId && a.FlightId == departureAirportBeforeChanges.FlightId);
            if (departureAirport != null)
            {
                departureAirport.AirportId = airportId;
                departureAirport.FlightId = flightId;
            }
            db.SaveChanges();
        }

        public void DeleteDepartureAirport(DepartureAirport departureAirport)
        {
            using AirportdbContext db = new();
            db.DepartureAirports.Remove(departureAirport);
            db.SaveChanges();
        }

        public List<DepartureAirport> GetAllDepartureAirports()
        {
            using AirportdbContext db = new();
            var allDepartureAirports = db.DepartureAirports.ToList();
            return allDepartureAirports;
        }

        public DepartureAirport GetDepartureAirportById(int departureAirportId)
        {
            using AirportdbContext db = new();
            return db.DepartureAirports.FirstOrDefault(a => a.AirportId == departureAirportId);
        }
    }
}
