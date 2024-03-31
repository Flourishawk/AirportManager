using Airport.Services.Interfaces;
using AirportManager.Models;

namespace AirportManager.Services.Implementations
{
    internal class CapacityService : ICapacityService
    {
        public void AddCapacity(Capacity capacity)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Capacities.Any(e1 => e1.CapacityId == capacity.CapacityId);
            if (!checkIfExist)
            {
                db.Capacities.Add(capacity);
                db.SaveChanges();
            }
        }

        public void UpdateCapacity(Capacity capacityBeforeChanges, string description)
        {
            using AirportdbContext db = new();
            Capacity? capacity = db.Capacities.FirstOrDefault(a => a.CapacityId == capacityBeforeChanges.CapacityId);
            if (capacity != null)
            {
                capacity.Description = description;
            }
            db.SaveChanges();
        }

        public void DeleteCapacity(Capacity capacity)
        {
            using AirportdbContext db = new();
            db.Capacities.Remove(capacity);
            db.SaveChanges();
        }

        public List<Capacity> GetAllCapacities()
        {
            using AirportdbContext db = new();
            var allCapacities = db.Capacities.ToList();
            return allCapacities;
        }

        public Capacity GetCapacityById(int capacityId)
        {
            using AirportdbContext db = new();
            return db.Capacities.FirstOrDefault(a => a.CapacityId == capacityId);
        }
    }
}
