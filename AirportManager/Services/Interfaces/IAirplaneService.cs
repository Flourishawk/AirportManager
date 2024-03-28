using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirplaneService
    {
        List<Airplane> GetAllAirplanes();
        void AddAirplane(Airplane airplane);
        void UpdateAirplane(Airplane airplaneBeforeChanges, int airlineId, int airplaneTypeId, int capacityId);
        void DeleteAirplane(Airplane airplane);
    }
}
