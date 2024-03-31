using Airport.Services.Implementations;
using Airport.Services.Interfaces;
using AirportManager.Models;
using AirportManager.Services.Implementations;
using AirportManager.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace AirportManager.Views
{
    public partial class EmployeeView : Window
    {
        private EmployeeVM _viewModel;

        private AirlineService _airlineService;
        private AirplaneService _airplaneService;
        private AirplaneTypeService _airplaneTypeService;
        private AirportConstructionService _airportConstructionService;
        private AirportLocationService _airportLocationService;
        private ArrivalAirportService _arrivalAirportService;
        private CapacityService _capacityService;
        private DepartmentService _departmentService;
        private DepartureAirportService _departureAirportService;
        private EmployeeService _employeeService;
        private FlightService _flightService;
        private HumanService _humanService;
        private PassangerService _passangerService;
        private TicketService _ticketService;
        private GenderService _genderService;

        public EmployeeView()
        {
            InitializeComponent();
            _viewModel = new EmployeeVM();
            DataContext = _viewModel;

            _airlineService = new AirlineService();
            _genderService = new GenderService();
            _flightService = new FlightService();
            _humanService = new HumanService();
            _employeeService = new EmployeeService();
            _passangerService = new PassangerService();
            _ticketService = new TicketService();
            _genderService = new GenderService();
            _airplaneService = new AirplaneService();
            _airplaneTypeService = new AirplaneTypeService();
            _airportConstructionService = new AirportConstructionService();
            _airportLocationService = new AirportLocationService();
            _arrivalAirportService = new ArrivalAirportService();
            _capacityService = new CapacityService();
            _departmentService = new DepartmentService();
            _departureAirportService = new DepartureAirportService();
        }
        private void ViewModel_DataUpdated(object sender, EventArgs e)
        {
            UpdateListView();
        }
        private void UpdateListView()
        {
            ViewAllTickets.ItemsSource = _viewModel.AllTickets;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            TabItem selectedTab = (TabItem)MainTab.SelectedItem;

            if (selectedTab.Name == "AirlineTab")
            {
                try
                {
                    Airline selectedAirline = (Airline)ViewAllAirlines.SelectedItem;

                    if (selectedAirline != null)
                    {
                        _airlineService.DeleteAirline(selectedAirline);
                        ViewAllAirlines.ItemsSource = _airlineService.GetAllAirlines();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirplaneTab")
            {
                try
                {
                    Airplane selectedAirplane = (Airplane)ViewAllAirplanes.SelectedItem;

                    if (selectedAirplane != null)
                    {
                        _airplaneService.DeleteAirplane(selectedAirplane);
                        ViewAllAirplanes.ItemsSource = _airplaneService.GetAllAirplanes();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirplaneTypeTab")
            {
                try
                {
                    AirplaneType selectedAirplaneType = (AirplaneType)ViewAllAirplaneTypes.SelectedItem;

                    if (selectedAirplaneType != null)
                    {
                        _airplaneTypeService.DeleteAirplaneType(selectedAirplaneType);
                        ViewAllAirplaneTypes.ItemsSource = _airplaneTypeService.GetAllAirplaneTypes();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirportConstructionTab")
            {
                try
                {
                    AirportConstruction selectedAirportConstruction = (AirportConstruction)ViewAllAirportConstructions.SelectedItem;

                    if (selectedAirportConstruction != null)
                    {
                        _airportConstructionService.DeleteAirportConstruction(selectedAirportConstruction);
                        ViewAllAirportConstructions.ItemsSource = _airportConstructionService.GetAllAirportConstructions();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirportLocationTab")
            {
                try
                {
                    AirportLocation selectedAirportLocation = (AirportLocation)ViewAllAirportLocations.SelectedItem;

                    if (selectedAirportLocation != null)
                    {
                        _airportLocationService.DeleteAirportLocation(selectedAirportLocation);
                        ViewAllAirportLocations.ItemsSource = _airportLocationService.GetAllAirportLocations();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "ArrivalAirportTab")
            {
                try
                {
                    ArrivalAirport selectedArrivalAirport = (ArrivalAirport)ViewAllArrivalAirports.SelectedItem;

                    if (selectedArrivalAirport != null)
                    {
                        _arrivalAirportService.DeleteArrivalAirport(selectedArrivalAirport);
                        ViewAllArrivalAirports.ItemsSource = _arrivalAirportService.GetAllArrivalAirports();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "CapacityTab")
            {
                try
                {
                    Capacity selectedCapacity = (Capacity)ViewAllCapacities.SelectedItem;

                    if (selectedCapacity != null)
                    {
                        _capacityService.DeleteCapacity(selectedCapacity);
                        ViewAllCapacities.ItemsSource = _capacityService.GetAllCapacities();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "DepartmentTab")
            {
                try
                {
                    Department selectedDepartment = (Department)ViewAllDepartments.SelectedItem;

                    if (selectedDepartment != null)
                    {
                        _departmentService.DeleteDepartment(selectedDepartment);
                        ViewAllDepartments.ItemsSource = _departmentService.GetAllDepartments();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "DepartureAirportTab")
            {
                try
                {
                    DepartureAirport selectedDepartureAirport = (DepartureAirport)ViewAllDepartureAirports.SelectedItem;

                    if (selectedDepartureAirport != null)
                    {
                        _departureAirportService.DeleteDepartureAirport(selectedDepartureAirport);
                        ViewAllDepartureAirports.ItemsSource = _departureAirportService.GetAllDepartureAirports();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "EmployeeTab")
            {
                try
                {
                    Employee selectedEmployee = (Employee)ViewAllEmployees.SelectedItem;

                    if (selectedEmployee != null)
                    {
                        _employeeService.DeleteEmployee(selectedEmployee);
                        ViewAllEmployees.ItemsSource = _employeeService.GetAllEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "FlightTab")
            {
                try
                {
                    Flight selectedFlight = (Flight)ViewAllFlights.SelectedItem;

                    if (selectedFlight != null)
                    {
                        _flightService.DeleteFlight(selectedFlight);
                        ViewAllFlights.ItemsSource = _flightService.GetAllFlights();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "GenderTab")
            {
                try
                {
                    Gender selectedGender = (Gender)ViewAllGenders.SelectedItem;

                    if (selectedGender != null)
                    {
                        _genderService.DeleteGender(selectedGender);
                        ViewAllGenders.ItemsSource = _genderService.GetAllGenders();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "HumanTab")
            {
                try
                {
                    Human selectedHuman = (Human)ViewAllHumans.SelectedItem;

                    if (selectedHuman != null)
                    {
                        _humanService.DeleteHuman(selectedHuman);
                        ViewAllHumans.ItemsSource = _humanService.GetAllHumans();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "PassangerTab")
            {
                try
                {
                    Passanger selectedPassanger = (Passanger)ViewAllPassangers.SelectedItem;

                    if (selectedPassanger != null)
                    {
                        _passangerService.DeletePassanger(selectedPassanger);
                        ViewAllPassangers.ItemsSource = _passangerService.GetAllPassangers();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "TicketTab")
            {
                try
                {
                    Ticket selectedTicket = (Ticket)ViewAllTickets.SelectedItem;

                    if (selectedTicket != null)
                    {
                        _ticketService.DeleteTicket(selectedTicket);
                        ViewAllTickets.ItemsSource = _ticketService.GetAllTickets();
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, оберіть рядок!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabItem selectedTab = (TabItem)MainTab.SelectedItem;
            int result;
            if (selectedTab.Name == "AirlineTab" && (int.TryParse(AirlineTabAirlineIdText.Text, out result)))
            {
                try
                {
                    Airline airline = new Airline { AirlineId = result, Description = AirlineTabDescriptionText.Text };

                    _airlineService.AddAirline(airline);
                    ViewAllAirlines.ItemsSource = _airlineService.GetAllAirlines();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirplaneTab" && (int.TryParse(AirplaneTabAirplaneIdText.Text, out int AirplaneId)) && (int.TryParse(AirplaneTabAirlineIdText.Text, out int AirlineId))
                 && (int.TryParse(AirplaneTabAirplaneTypeIdText.Text, out int AirplaneTypeId)) && (int.TryParse(AirplaneTabCapacityIdText.Text, out int CapacityId))

                )
            {
                try
                {
                    Airplane airplane = new Airplane { AirplaneId = AirplaneId, AirlineId = AirlineId, AirplaneTypeId = AirplaneTypeId, CapacityId = CapacityId };

                    _airplaneService.AddAirplane(airplane);
                    ViewAllAirplanes.ItemsSource = _airplaneService.GetAllAirplanes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirplaneTypeTab" && (int.TryParse(AirplaneTypeTabAirplaneTypeIdText.Text, out int AirplaneTypeTabAirplaneTypeId)))
            {
                try
                {
                    AirplaneType airplaneType = new AirplaneType { AirplaneTypeId = AirplaneTypeTabAirplaneTypeId, Description = AirplaneTypeTabDescriptionText.Text };

                    _airplaneTypeService.AddAirplaneType(airplaneType);
                    ViewAllAirplaneTypes.ItemsSource = _airplaneTypeService.GetAllAirplaneTypes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirportConstructionTab" && (int.TryParse(AirportConstructionTabAirportIdText.Text, out int AirportConstructionTabAirportId))
                 && (int.TryParse(AirportConstructionTabLocationIdText.Text, out int AirportConstructionTabLocationId))
                  && (int.TryParse(AirportConstructionTabAirlineIdText.Text, out int AirportConstructionTabAirlinetId))
                )
            {
                try
                {
                    AirportConstruction airportConstruction = new AirportConstruction { AirportId = AirportConstructionTabAirportId, LocationId = AirportConstructionTabLocationId, AirlineId = AirportConstructionTabAirlinetId };

                    _airportConstructionService.AddAirportConstruction(airportConstruction);
                    ViewAllAirportConstructions.ItemsSource = _airportConstructionService.GetAllAirportConstructions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirportLocationTab" && (int.TryParse(AirportLocationTabLocationIdText.Text, out int AirportLocationTabLocationId)))
            {
                try
                {
                    AirportLocation airportLocation = new AirportLocation
                    {
                        LocationId = AirportLocationTabLocationId,
                        Country = AirportLocationTabCountryText.Text,
                        City = AirportLocationTabCityText.Text,
                        Latitude = AirportLocationTabLatitudeText.Text,
                        Longtitude = AirportLocationTabLongtitudeText.Text
                    };

                    _airportLocationService.AddAirportLocation(airportLocation);
                    ViewAllAirportLocations.ItemsSource = _airportLocationService.GetAllAirportLocations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "ArrivalAirportTab" && (int.TryParse(ArrivalAirportTabFlightIdText.Text, out int ArrivalAirportTabFlightId)) && (int.TryParse(ArrivalAirportTabAirportIdText.Text, out int ArrivalAirportTabAirportId)))
            {
                try
                {
                    ArrivalAirport arrivalAirport = new ArrivalAirport
                    {
                        FlightId = ArrivalAirportTabFlightId,
                        AirportId = ArrivalAirportTabAirportId
                    };

                    _arrivalAirportService.AddArrivalAirport(arrivalAirport);
                    ViewAllArrivalAirports.ItemsSource = _arrivalAirportService.GetAllArrivalAirports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "CapacityTab" && (int.TryParse(CapacityTabCapacityIdText.Text, out int CapacityTabCapacityId)))
            {
                try
                {
                    Capacity capacity = new Capacity
                    {
                        CapacityId = CapacityTabCapacityId,
                        Description = CapacityTabDescriptionText.Text
                    };

                    _capacityService.AddCapacity(capacity);
                    ViewAllCapacities.ItemsSource = _capacityService.GetAllCapacities();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "DepartmentTab" && (int.TryParse(DepartmentTabDepartmentIdText.Text, out int DepartmentTabDepartmentId)))
            {
                try
                {
                    Department department = new Department
                    {
                        DepartmentId = DepartmentTabDepartmentId,
                        Description = DepartmentTabDescriptionText.Text
                    };

                    _departmentService.AddDepartment(department);
                    ViewAllDepartments.ItemsSource = _departmentService.GetAllDepartments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "DepartureAirportTab" && (int.TryParse(DepartureAirportTabFlightIdText.Text, out int DepartureAirportTabFlightId)) && (int.TryParse(DepartureAirportTabAirportIdText.Text, out int DepartureAirportTabAirportId)))
            {
                try
                {
                    DepartureAirport departureAirport = new DepartureAirport
                    {
                        FlightId = DepartureAirportTabFlightId,
                        AirportId = DepartureAirportTabAirportId
                    };

                    _departureAirportService.AddDepartureAirport(departureAirport);
                    ViewAllDepartureAirports.ItemsSource = _departureAirportService.GetAllDepartureAirports();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "EmployeeTab" && (int.TryParse(EmployeeTabEmployeeIdText.Text, out int EmployeeTabEmployeeId))
                && (decimal.TryParse(EmployeeTabSalaryText.Text, out decimal EmployeeTabSalary))
                && (int.TryParse(EmployeeTabAirplaneIdText.Text, out int EmployeeTabAirplaneId))
                    && (int.TryParse(EmployeeTabDepartmentIdText.Text, out int EmployeeTabDepartmentId)))
            {
                try
                {
                    Employee employee = new Employee
                    {
                        EmployeeId = EmployeeTabEmployeeId,
                        Salary = EmployeeTabSalary,
                        Username = EmployeeTabSalaryText.Text,
                        AirplaneId = EmployeeTabAirplaneId,
                        DepartmentId = EmployeeTabDepartmentId
                    };

                    _employeeService.AddEmployee(employee);
                    ViewAllEmployees.ItemsSource = _employeeService.GetAllEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "FlightTab" && (int.TryParse(FlightTabFlightIdText.Text, out int FlightTabFlightId))
                && (DateTime.TryParse(FlightTabDepartureTimeText.Text, out DateTime FlightTabDepartureTime))
                && (DateTime.TryParse(FlightTabArrivalTimeText.Text, out DateTime FlightTabArrivalTime))
                    && (int.TryParse(FlightTabAirlineIdText.Text, out int FlightTabAirlineId)))
            {
                try
                {
                    Flight flight = new Flight
                    {
                        FlightId = FlightTabFlightId,
                        DepartureTime = FlightTabDepartureTime,
                        ArrivalTime = FlightTabArrivalTime,
                        AirlineId = FlightTabAirlineId
                    };

                    _flightService.AddFlight(flight);
                    ViewAllFlights.ItemsSource = _flightService.GetAllFlights();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "GenderTab" && (int.TryParse(GenderTabGenderIdText.Text, out int GenderTabGenderId)))
            {
                try
                {
                    Gender gender = new Gender
                    {
                        GenderId = GenderTabGenderId,
                        GenderName = GenderTabGenderNameText.Text
                    };

                    _genderService.AddGender(gender);
                    ViewAllGenders.ItemsSource = _genderService.GetAllGenders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "HumanTab" && (int.TryParse(HumanTabHumanIdText.Text, out int HumanTabHumanId))
                && (DateOnly.TryParse(HumanTabBirthdateText.Text, out DateOnly HumanTabBirthdate))
                && (int.TryParse(HumanTabGenderIdText.Text, out int HumanTabGenderId))
                && (int.TryParse(HumanTabPassangerIdText.Text, out int HumanTabPassangerId))
                && (int.TryParse(HumanTabEmployeeIdText.Text, out int HumanTabEmployeeId)))
            {
                try
                {
                    Human human = new Human
                    {
                        HumanId = HumanTabHumanId,
                        Name = HumanTabNameText.Text,
                        Surname = HumanTabSurnameText.Text,
                        Email = HumanTabEmailText.Text,
                        Telephone = HumanTabTelephoneText.Text,
                        Birthdate = HumanTabBirthdate,
                        GenderId = HumanTabGenderId,
                        PassangerId = HumanTabPassangerId,
                        EmployeeId = HumanTabEmployeeId,
                    };

                    _humanService.AddHuman(human);
                    ViewAllHumans.ItemsSource = _humanService.GetAllHumans();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "PassangerTab" && (int.TryParse(PassangerTabPassangerIdText.Text, out int PassangerTabPassangerId)))
            {
                try
                {
                    Passanger passanger = new Passanger
                    {
                        PassangerId = PassangerTabPassangerId,
                    };

                    _passangerService.AddPassanger(passanger);
                    ViewAllPassangers.ItemsSource = _passangerService.GetAllPassangers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "TicketTab" && (int.TryParse(TicketTabTicketIdText.Text, out int TicketTabTicketId))
                 && (DateTime.TryParse(TicketTabDepartureTimeText.Text, out DateTime TicketTabDepartureTime))
                 && (DateTime.TryParse(TicketTabPurchaseTimeText.Text, out DateTime TicketTabPurchaseTime))
                 && (DateTime.TryParse(TicketTabExpirationTimeText.Text, out DateTime TicketTabExpirationTime))
                 && (sbyte.TryParse(TicketTabSeatText.Text, out sbyte TicketTabSeat))
                 && (int.TryParse(TicketTabPassangerIdText.Text, out int TicketTabPassangerId))
                )
            {
                try
                {
                    Ticket ticket = new Ticket
                    {
                        TicketId = TicketTabTicketId,
                        DepartureTime = TicketTabDepartureTime,
                        PurchaseTime = TicketTabPurchaseTime,
                        ExpirationTime = TicketTabExpirationTime,
                        Seat = TicketTabSeat,
                        PassangerId = TicketTabPassangerId
                    };

                    _ticketService.AddTicket(ticket);
                    ViewAllTickets.ItemsSource = _ticketService.GetAllTickets();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TabItem selectedTab = (TabItem)MainTab.SelectedItem;

            if (selectedTab.Name == "AirlineTab")
            {
                try
                {
                    int airlineId = int.Parse(AirlineTabAirlineIdText.Text);
                    Airline airline = _airlineService.GetAirlineById(airlineId);
                    List<Airline> filteredAirlines = new List<Airline>();
                    filteredAirlines.Add(airline);
                    ViewAllAirlines.ItemsSource = filteredAirlines;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }else if(selectedTab.Name == "AirplaneTab")
            {
                try
                {
                    int airplaneId = int.Parse(AirplaneTabAirplaneIdText.Text);
                    Airplane airplane = _airplaneService.GetAirplaneById(airplaneId);
                    List<Airplane> filteredAirplanes = new List<Airplane>();
                    filteredAirplanes.Add(airplane);
                    ViewAllAirplanes.ItemsSource = filteredAirplanes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirplaneTypeTab")
            {
                try
                {
                    int airplaneTypeId = int.Parse(AirplaneTypeTabAirplaneTypeIdText.Text);
                    AirplaneType airplaneType = _airplaneTypeService.GetAirplaneTypeById(airplaneTypeId);
                    List<AirplaneType> filteredAirplaneTypes = new List<AirplaneType>();
                    filteredAirplaneTypes.Add(airplaneType);
                    ViewAllAirplaneTypes.ItemsSource = filteredAirplaneTypes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "AirportConstructionTab")
            {
                try
                {
                    int airportConstructionId = int.Parse(AirportConstructionTabAirportIdText.Text);
                    AirportConstruction airportConstruction = _airportConstructionService.GetAirportConstructionById(airportConstructionId);
                    List<AirportConstruction> filteredAirportConstruction = new List<AirportConstruction>();
                    filteredAirportConstruction.Add(airportConstruction);
                    ViewAllAirportConstructions.ItemsSource = filteredAirportConstruction;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "ArrivalAirportTab")
            {
                try
                {
                    int arrivalAirportId = int.Parse(ArrivalAirportTabFlightIdText.Text);
                    ArrivalAirport arrivalAirport = _arrivalAirportService.GetArrivalAirportById(arrivalAirportId);
                    List<ArrivalAirport> filteredArrivalAirport = new List<ArrivalAirport>();
                    filteredArrivalAirport.Add(arrivalAirport);
                    ViewAllArrivalAirports.ItemsSource = filteredArrivalAirport;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "CapacityTab")
            {
                try
                {
                    int capacityId = int.Parse(CapacityTabCapacityIdText.Text);
                    Capacity capacity = _capacityService.GetCapacityById(capacityId);
                    List<Capacity> filteredCapacity = new List<Capacity>();
                    filteredCapacity.Add(capacity);
                    ViewAllCapacities.ItemsSource = filteredCapacity;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "DepartmentTab")
            {
                try
                {
                    int departmentId = int.Parse(DepartmentTabDepartmentIdText.Text);
                    Department department = _departmentService.GetDepartmentsById(departmentId);
                    List<Department> filteredDepartment = new List<Department>();
                    filteredDepartment.Add(department);
                    ViewAllDepartments.ItemsSource = filteredDepartment;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "DepartureAirportTab")
            {
                try
                {
                    int departureId = int.Parse(DepartureAirportTabAirportIdText.Text);
                    DepartureAirport departureAirport = _departureAirportService.GetDepartureAirportById(departureId);
                    List<DepartureAirport> filteredDepartureAirport = new List<DepartureAirport>();
                    filteredDepartureAirport.Add(departureAirport);
                    ViewAllDepartureAirports.ItemsSource = filteredDepartureAirport;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "EmployeeTab")
            {
                try
                {
                    int employeeId = int.Parse(EmployeeTabEmployeeIdText.Text);
                    Employee employee = _employeeService.GetEmployeeById(employeeId);
                    List<Employee> filteredEmployee = new List<Employee>();
                    filteredEmployee.Add(employee);
                    ViewAllEmployees.ItemsSource = filteredEmployee;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "FlightTab")
            {
                try
                {
                    int flightId = int.Parse(FlightTabFlightIdText.Text);
                    Flight flight = _flightService.GetFlightById(flightId);
                    List<Flight> filteredFlight = new List<Flight>();
                    filteredFlight.Add(flight);
                    ViewAllFlights.ItemsSource = filteredFlight;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "GenderTab")
            {
                try
                {
                    int genderId = int.Parse(GenderTabGenderIdText.Text);
                    Gender gender = _genderService.GetGenderById(genderId);
                    List<Gender> filteredGender = new List<Gender>();
                    filteredGender.Add(gender);
                    ViewAllGenders.ItemsSource = filteredGender;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "HumanTab")
            {
                try
                {
                    int humanId = int.Parse(HumanTabHumanIdText.Text);
                    Human human = _humanService.GetHumanById(humanId);
                    List<Human> filteredHuman = new List<Human>();
                    filteredHuman.Add(human);
                    ViewAllHumans.ItemsSource = filteredHuman;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "PassangerTab")
            {
                try
                {
                    int passangerId = int.Parse(PassangerTabPassangerIdText.Text);
                    Passanger passanger = _passangerService.GetPassangerById(passangerId);
                    List<Passanger> filteredPassanger = new List<Passanger>();
                    filteredPassanger.Add(passanger);
                    ViewAllPassangers.ItemsSource = filteredPassanger;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (selectedTab.Name == "TicketTab")
            {
                try
                {
                    int ticketId = int.Parse(TicketTabTicketIdText.Text);
                    Ticket ticket = _ticketService.GetTicketById(ticketId);
                    List<Ticket> filteredTicket = new List<Ticket>();
                    filteredTicket.Add(ticket);
                    ViewAllTickets.ItemsSource = filteredTicket;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }



    }
}
