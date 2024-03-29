using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IHumanService
    {
        List<Human> GetAllHumans();
        void AddHuman(Human human);
        void UpdateHuman(Human humanBeforeChanges, string name, string surname, string email, string telephone, DateOnly birthdate, int gehderId, int passangerId, int employeeId);
        void DeleteHuman(Human human);
    }
}
