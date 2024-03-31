using AirportManager.Models;
using Airport.Services.Interfaces;

namespace Airport.Services.Implementations
{
    internal class AirplaneService : IAirplaneService
    {
        public void AddAirplane(Airplane airplane)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Airplanes.Any(e1 => e1.AirplaneId == airplane.AirplaneId);
            if (!checkIfExist)
            {
                db.Airplanes.Add(airplane);
                db.SaveChanges();
            }
        }

        public void UpdateAirplane(Airplane airplaneBeforeChanges, int airlineId, int airplaneTypeId, int capacityId)
        {
            using AirportdbContext db = new();
            Airplane? airplane = db.Airplanes.FirstOrDefault(a => a.AirplaneId == airplaneBeforeChanges.AirplaneId);
            if (airplane != null)
            {
                airplane.AirlineId = airlineId;
                airplane.AirplaneTypeId = airplaneTypeId;
                airplane.CapacityId = capacityId;
            }
            db.SaveChanges();
        }

        public void DeleteAirplane(Airplane airplane)
        {
            using AirportdbContext db = new();
            db.Airplanes.Remove(airplane);
            db.SaveChanges();
        }

        public List<Airplane> GetAllAirplanes()
        {
            using AirportdbContext db = new();
            var allAirplanes = db.Airplanes.ToList();
            return allAirplanes;
        }

        public Airplane GetAirplaneById(int airplaneId)
        {
            using AirportdbContext db = new();
            return db.Airplanes.FirstOrDefault(a => a.AirplaneId == airplaneId);
        }
    }
}
