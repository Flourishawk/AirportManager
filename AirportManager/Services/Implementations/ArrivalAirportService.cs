using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class ArrivalAirportService:IArrivalAirportService
    {
        public void AddArrivalAirport(ArrivalAirport arrivalAirport)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.ArrivalAirports.Any(e1 => e1.AirportId == arrivalAirport.AirportId && e1.FlightId == arrivalAirport.FlightId);
            if (!checkIfExist)
            {
                db.ArrivalAirports.Add(arrivalAirport);
                db.SaveChanges();
            }
        }

        public void UpdateArrivalAirport(ArrivalAirport arrivalAirportBeforeChanges, int flightId, int airportId)
        {
            using AirportdbContext db = new();
            ArrivalAirport? arrivalAirport = db.ArrivalAirports.FirstOrDefault(a => a.AirportId == arrivalAirportBeforeChanges.AirportId && a.FlightId == arrivalAirportBeforeChanges.FlightId);
            if (arrivalAirport != null)
            {
                arrivalAirport.AirportId = airportId;
                arrivalAirport.FlightId = flightId;
            }
            db.SaveChanges();
        }

        public void DeleteArrivalAirport(ArrivalAirport arrivalAirport)
        {
            using AirportdbContext db = new();
            db.ArrivalAirports.Remove(arrivalAirport);
            db.SaveChanges();
        }

        public List<ArrivalAirport> GetAllArrivalAirports()
        {
            using AirportdbContext db = new();
            var allArrivalAirports = db.ArrivalAirports.ToList();
            return allArrivalAirports;
        }
    }
}
