using Airport.Services.Implementations;
using AirportManager.Models;
using AirportManager.ViewModels;

namespace AirportManager.ViewModels
{
    internal class EmployeeVM : ViewModelBase
    {
        public List<Airline> AllAirlines { get; set; }

        public EmployeeVM()
        {
            AirlineService airlineService = new AirlineService();
            AllAirlines = airlineService.GetAllAirlines();
            OnPropertyChanged("AllAirlines");
        }
    }
}