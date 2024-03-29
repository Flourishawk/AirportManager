using Airport.Services.Interfaces;
using AirportManager.Models;

namespace AirportManager.Services.Implementations
{
    internal class AirplaneTypeService : IAirplaneTypeService
    {
        public void AddAirplaneType(AirplaneType airplaneType)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.AirplaneTypes.Any(e1 => e1.AirplaneTypeId == airplaneType.AirplaneTypeId);
            if (!checkIfExist)
            {
                db.AirplaneTypes.Add(airplaneType);
                db.SaveChanges();
            }
        }

        public void UpdateAirplaneType(AirplaneType airplaneTypeBeforeChanges, string description)
        {
            using AirportdbContext db = new();
            AirplaneType? airplaneType = db.AirplaneTypes.FirstOrDefault(a => a.AirplaneTypeId == airplaneTypeBeforeChanges.AirplaneTypeId);
            if (airplaneType != null)
            {
                airplaneType.Description = description;
            }
            db.SaveChanges();
        }

        public void DeleteAirplaneType(AirplaneType airplaneType)
        {
            using AirportdbContext db = new();
            db.AirplaneTypes.Remove(airplaneType);
            db.SaveChanges();
        }

        public List<AirplaneType> GetAllAirplaneTypes()
        {
            using AirportdbContext db = new();
            var allAirplaneTypes = db.AirplaneTypes.ToList();
            return allAirplaneTypes;
        }

    }
}
