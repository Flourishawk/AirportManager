using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IHumanService
    {
        List<Human> GetAllHuman();
        void AddHuman(Human human);
        void UpdateHuman(Human human, );
        void DeleteHuman(Human human);
    }
}
