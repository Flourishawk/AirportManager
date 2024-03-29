using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirplaneTypeService
    {
        List<AirplaneType> GetAllAirplaneType();
        void AddAirplaneType(AirplaneType airplaneType);
        void UpdateAirplaneType(AirplaneType airplaneTypeBeforeCnhages, string description);
        void DeleteAirplaneType(AirplaneType airplaneType);
    }
}
