using System.Windows;
using AirportManager.Models;
using AirportManager.ViewModels;

namespace AirportManager.Views
{
    public partial class EmployeeView : Window
    {
        public EmployeeView()
        {
            InitializeComponent();
            DataContext = new EmployeeVM();
        }
    }
}
