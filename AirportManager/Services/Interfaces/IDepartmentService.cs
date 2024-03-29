using AirportManager.Models;

namespace AirportManager.Services.Interfaces
{
    internal interface IDepartmentService
    {
        List<Department> GetAllDepartments();
        void AddDepartment(Department department);
        void UpdateDepartment(Department departmentBeforeChanges, string description);
        void DeleteDepartment(Department department);
    }
}
