using Airport.Services.Implementations;
using AirportManager.Models;
using AirportManager.Services.Implementations;

namespace AirportManager.ViewModels
{
    internal class EmployeeVM : ViewModelBase
    {
        public List<Airline> AllAirlines { get; set; }
        public List<Airplane> AllAirplanes { get; set; }
        
        public List<AirplaneType> AllAirplaneTypes { get; set; }
        public List<AirportConstruction> AllAirportConstructions { get; set; }
        public List<AirportLocation> AllAirportLocations { get; set; }
        public List<ArrivalAirport> AllArrivalAirports { get; set; }

        public List<Capacity> AllCapacities { get; set; }
        public List<Department> AllDepartments { get; set; }
        public List<DepartureAirport> AllDepartureAirports { get; set; }
        public List<Employee> AllEmployees { get; set; }

        public List<Flight> AllFlights { get; set; }
        
        public List<Gender> AllGenders { get; set; }
        public List<Human> AllHumans { get; set; }
        public List<Passanger> AllPassangers { get; set; }
        public List<Ticket> AllTickets { get; set; }


        public EmployeeVM()
        {
            AirlineService airlineService = new AirlineService();
            AllAirlines = airlineService.GetAllAirlines();

            AirplaneService airplaneService = new AirplaneService();
            AllAirplanes = airplaneService.GetAllAirplanes();

            AirplaneTypeService airplaneTypeService = new AirplaneTypeService();
            AllAirplaneTypes = airplaneTypeService.GetAllAirplaneTypes();

            AirportConstructionService airportConstructionService = new AirportConstructionService();
            AllAirportConstructions = airportConstructionService.GetAllAirportConstructions();

            AirportLocationService airportLocationService = new AirportLocationService();
            AllAirportLocations = airportLocationService.GetAllAirportLocations();

            ArrivalAirportService arrivalAirportService = new ArrivalAirportService();
            AllArrivalAirports = arrivalAirportService.GetAllArrivalAirports();

            CapacityService capacityService = new CapacityService();
            AllCapacities = capacityService.GetAllCapacities();

            DepartmentService departmentService = new DepartmentService();
            AllDepartments = departmentService.GetAllDepartments();

            DepartureAirportService departureAirportService = new DepartureAirportService();
            AllDepartureAirports = departureAirportService.GetAllDepartureAirports();

            EmployeeService employeeService = new EmployeeService();
            AllEmployees = employeeService.GetAllEmployees();

            FlightService flightService = new FlightService();
            AllFlights = flightService.GetAllFlights();

            GenderService genderService = new GenderService();
            AllGenders = genderService.GetAllGenders();

            HumanService humanService = new HumanService();
            AllHumans = humanService.GetAllHumans();

            PassangerService passangerService = new PassangerService();
            AllPassangers = passangerService.GetAllPassangers();

            TicketService ticketService = new TicketService();
            AllTickets = ticketService.GetAllTickets();



            OnPropertyChanged("AllAirplanes");
            OnPropertyChanged("AllAirlines");
            OnPropertyChanged("AllAirlaneTypes");
            OnPropertyChanged("AllAirportConstructions");
            OnPropertyChanged("AllAirportLocations");
            OnPropertyChanged("AllArrivalAirports");
            OnPropertyChanged("AllAllCapacities");
            OnPropertyChanged("AllDepartments");
            OnPropertyChanged("AllDepartureAirports");
            OnPropertyChanged("AllAllEmployees");
            OnPropertyChanged("AllFlights");
            OnPropertyChanged("AllGenders");
            OnPropertyChanged("AllHumans");
            OnPropertyChanged("AllPassangers");
            OnPropertyChanged("AllTickets");
        }

    }
}