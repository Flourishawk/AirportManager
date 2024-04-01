using System.Windows.Input;
using AirportManager.Models;
using AirportManager.Commands;
using System.Windows;
using AirportManager.Services.Implementations;

namespace AirportManager.ViewModels
{

    public class LoginVM : ViewModelBase
    {
        private readonly Employee employee;
        public ICommand LoginCommand { get; }

        public LoginVM()
        {
            employee = new Employee();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        public string Username
        {
            get => employee.Username;
            set
            {
                employee.Username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => employee.Password;
            set
            {
                employee.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private static void LoggedIn(object parameter)
        {
            
        }
    }
}
