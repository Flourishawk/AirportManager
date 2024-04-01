using AirportManager.Models;
using AirportManager.Services.Implementations;
using AirportManager.Views;
using System.Windows;

namespace AirportManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employeeList = employeeService.GetAllEmployees();

            using AirportdbContext db = new();
            Employee employee = db.Employees.FirstOrDefault(a => a.Username == EmailTextBox.Text);

            if (employee is not null)
            {
                if (employee.Password == PasswordTextBox.Text)
                {
                    EmployeeView employeeView = new EmployeeView();
                    employeeView.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильний логін або пароль");
                }
            }
            else
            {
                MessageBox.Show("Користувач з такою поштою не знайдений");
            }
        }
    }
}