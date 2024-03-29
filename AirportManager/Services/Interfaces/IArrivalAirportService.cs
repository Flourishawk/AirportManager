using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IArrivalAirportService
    {
        List<ArrivalAirport> GetAllArrivalAirport();
        void AddArrivalAirport(ArrivalAirport airportConstruction);
        void UpdateArrivalAirport(ArrivalAirport arrivalAirportBeforeChanges,);
        void DeleteArrivalAirport(ArrivalAirport airportConstruction);
    }
}
