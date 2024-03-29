using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IArrivalAirportService
    {
        List<ArrivalAirport> GetAllArrivalAirports();
        void AddArrivalAirport(ArrivalAirport arrivalAirport);
        void UpdateArrivalAirport(ArrivalAirport arrivalAirportBeforeChanges, int flightId, int airportId);
        void DeleteArrivalAirport(ArrivalAirport arrivalAirport);
    }
}
