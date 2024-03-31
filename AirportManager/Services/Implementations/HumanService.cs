using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class HumanService : IHumanService
    {
        public void AddHuman(Human human)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Humans.Any(e1 => e1.HumanId == human.HumanId);
            if (!checkIfExist)
            {
                db.Humans.Add(human);
                db.SaveChanges();
            }
        }

        public void UpdateHuman(Human humanBeforeChanges, string name, string surname, string email, string telephone, DateOnly birthdate, int gehderId, int passangerId, int employeeId)
        {
            using AirportdbContext db = new();
            Human? human = db.Humans.FirstOrDefault(a => a.HumanId == humanBeforeChanges.HumanId);
            if (human != null)
            {
                human.Name = name;
                human.Surname = surname;
                human.Email = email;
                human.Telephone = telephone;
                human.Birthdate = birthdate;
                human.GenderId = gehderId;
                human.PassangerId = passangerId;
                human.EmployeeId = employeeId;
            }
            db.SaveChanges();
        }

        public void DeleteHuman(Human human)
        {
            using AirportdbContext db = new();
            db.Humans.Remove(human);
            db.SaveChanges();
        }

        public List<Human> GetAllHumans()
        {
            using AirportdbContext db = new();
            var allHumans = db.Humans.ToList();
            return allHumans;
        }

        public Human GetHumanById(int humanId)
        {
            using AirportdbContext db = new();
            return db.Humans.FirstOrDefault(a => a.HumanId == humanId);
        }
    }
}
