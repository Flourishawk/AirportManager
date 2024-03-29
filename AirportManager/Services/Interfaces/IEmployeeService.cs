using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employeeBeforeChanges, decimal salary, string username, string password, int airplaneId, int departureId);
        void DeleteEmployee(Employee employee);
    }
}
