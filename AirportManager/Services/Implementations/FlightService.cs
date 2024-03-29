using Airport.Services.Interfaces;
using AirportManager.Models;

namespace AirportManager.Services.Implementations
{
    internal class FlightService : IFlightService
    {
        public void AddFlight(Flight flight)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Flights.Any(e1 => e1.FlightId == flight.FlightId);
            if (!checkIfExist)
            {
                db.Flights.Add(flight);
                db.SaveChanges();
            }
        }

        public void UpdateFlight(Flight flightBeforeChanges, DateTime departureTime, DateTime arrivalTime, int airlineId)
        {
            using AirportdbContext db = new();
            Flight? flight = db.Flights.FirstOrDefault(a => a.FlightId == flightBeforeChanges.FlightId);
            if (flight != null)
            {
                flight.DepartureTime = departureTime;
                flight.ArrivalTime = arrivalTime;
                flight.AirlineId = airlineId;
            }
            db.SaveChanges();
        }

        public void DeleteFlight(Flight flight)
        {
            using AirportdbContext db = new();
            db.Flights.Remove(flight);
            db.SaveChanges();
        }

        public List<Flight> GetAllFlights()
        {
            using AirportdbContext db = new();
            var allFlights = db.Flights.ToList();
            return allFlights;
        }
    }
}
