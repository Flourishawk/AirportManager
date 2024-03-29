using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IPassangerService
    {
        List<Passanger> GetAllPassangers();
        void AddPassanger(Passanger passanger);
        void DeletePassanger(Passanger passanger);
    }
}
