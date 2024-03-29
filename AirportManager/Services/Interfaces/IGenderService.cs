using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IGenderService
    {
        List<Gender> GetAllGender();
        void AddGender(Gender gender);
        void UpdateGender(Gender gender, );
        void DeleteGender(Gender gender);
    }
}
