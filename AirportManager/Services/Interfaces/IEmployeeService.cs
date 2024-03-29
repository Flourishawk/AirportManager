using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IEmployeeService
    {
        List<Employee> GetAllEmployee();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee, );
        void DeleteEmployee(Employee employee);
    }
}
