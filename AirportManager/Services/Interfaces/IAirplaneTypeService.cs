using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirplaneTypeService
    {
        List<AirplaneType> GetAllAirplaneTypes();
        void AddAirplaneType(AirplaneType airplaneType);
        void UpdateAirplaneType(AirplaneType airplaneTypeBeforeChanges, string description);
        void DeleteAirplaneType(AirplaneType airplaneType);
    }
}
