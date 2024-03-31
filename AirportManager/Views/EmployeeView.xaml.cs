using Airport.Services.Implementations;
using Airport.Services.Interfaces;
using AirportManager.Models;
using AirportManager.Services.Implementations;
using AirportManager.Services.Interfaces;
using AirportManager.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

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

            _viewModel.DataUpdated += ViewModel_DataUpdated;
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
                    AirplaneType selectedAirplaneType = (AirplaneType)ViewAllAirplaneType.SelectedItem;

                    if (selectedAirplaneType != null)
                    {
                        _airplaneTypeService.DeleteAirplaneType(selectedAirplaneType);
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
                    AirportConstruction selectedAirportConstruction = (AirportConstruction)ViewAllAirportConstruction.SelectedItem;

                    if (selectedAirportConstruction != null)
                    {
                        _airportConstructionService.DeleteAirportConstruction(selectedAirportConstruction);
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
                        CollectionViewSource.GetDefaultView(ViewAllTickets.ItemsSource).Refresh();
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
                    Airline airline = new Airline{ AirlineId = result, Description = AirlineTabDescriptionText.Text};

                    _airlineService.AddAirline(airline);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка під час збереження, ймовірно у об'єкта лишилися вторинні ключі в інших моделях" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
