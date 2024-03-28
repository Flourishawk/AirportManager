using AirportManager.Models;

namespace Airport.Services.Interfaces
{
    internal interface IAirportConstructionService
    {
        List<AirportConstruction> GetAllAirportConstructions();
        void AddAirportConstruction(AirportConstruction airportConstruction);
        void UpdateAirportConstruction(AirportConstruction airportConstructionBeforeChanges, int locationId, int airlineId);
        void DeleteAirportConstruction(AirportConstruction airportConstruction);
    }
}
