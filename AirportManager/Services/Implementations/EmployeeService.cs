using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class EmployeeService : IEmployeeService
    {
        public void AddEmployee(Employee employee)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Employees.Any(e1 => e1.EmployeeId == employee.EmployeeId);
            if (!checkIfExist)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employeeBeforeChanges, decimal salary, string username, string password, int airplaneId, int departureId)
        {
            using AirportdbContext db = new();
            Employee? employee = db.Employees.FirstOrDefault(a => a.EmployeeId == employeeBeforeChanges.EmployeeId);
            if (employee != null)
            {
                employee.Salary = salary;
                employee.Username = username;
                employee.Password = password;
                employee.AirplaneId = airplaneId;
                employee.DepartmentId = departureId;
            }
            db.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            using AirportdbContext db = new();
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            using AirportdbContext db = new();
            var allEmployees = db.Employees.ToList();
            return allEmployees;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            using AirportdbContext db = new();
            return db.Employees.FirstOrDefault(a => a.EmployeeId == employeeId);
        }
    }
}
