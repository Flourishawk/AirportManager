using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class GenderService : IGenderService
    {
        public void AddGender(Gender gender)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Genders.Any(e1 => e1.GenderId == gender.GenderId);
            if (!checkIfExist)
            {
                db.Genders.Add(gender);
                db.SaveChanges();
            }
        }

        public void UpdateGender(Gender genderBeforeChanges, string genderName)
        {
            using AirportdbContext db = new();
            Gender? gender = db.Genders.FirstOrDefault(a => a.GenderId == genderBeforeChanges.GenderId);
            if (gender != null)
            {
                gender.GenderName = genderName;
            }
            db.SaveChanges();
        }

        public void DeleteGender(Gender gender)
        {
            using AirportdbContext db = new();
            db.Genders.Remove(gender);
            db.SaveChanges();
        }

        public List<Gender> GetAllGenders()
        {
            using AirportdbContext db = new();
            var allGenders = db.Genders.ToList();
            return allGenders;
        }
    }
}
