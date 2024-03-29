using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IGenderService
    {
        List<Gender> GetAllGenders();
        void AddGender(Gender gender);
        void UpdateGender(Gender genderBeforeChanges, string genderName);
        void DeleteGender(Gender gender);
    }
}
