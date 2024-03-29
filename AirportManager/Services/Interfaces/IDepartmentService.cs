using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IDepartmentService
    {
        List<Department> GetAllDepartment();
        void AddDepartment(Department department);
        void UpdateDepartment(Department department, );
        void DeleteDepartment(Department department);
    }
}
