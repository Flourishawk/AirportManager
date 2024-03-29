using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class PassangerService : IPassangerService
    {
        public void AddPassanger(Passanger passanger)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Passangers.Any(e1 => e1.PassangerId == passanger.PassangerId);
            if (!checkIfExist)
            {
                db.Passangers.Add(passanger);
                db.SaveChanges();
            }
        }

        public void DeletePassanger(Passanger passanger)
        {
            using AirportdbContext db = new();
            db.Passangers.Remove(passanger);
            db.SaveChanges();
        }

        public List<Passanger> GetAllPassangers()
        {
            using AirportdbContext db = new();
            var allPassangers = db.Passangers.ToList();
            return allPassangers;
        }
    }
}
