using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface ICapacityService
    {
        List<Capacity> GetAllCapacity();
        void AddCapacity(Capacity capacity);
        void UpdateCapacity(Capacity capacityBeforeChanges, string description);
        void DeleteCapacity(Capacity capacity);
    }
}
