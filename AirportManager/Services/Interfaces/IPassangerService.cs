using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IPassangerService
    {
        List<Passanger> GetAllPassanger();
        void AddPassanger(Passanger passanger);
        void UpdatePassanger(Passanger passanger, );
        void DeletePassanger(Passanger passanger);
    }
}
