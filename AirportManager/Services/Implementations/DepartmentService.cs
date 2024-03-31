using AirportManager.Models;
using AirportManager.Services.Interfaces;

namespace AirportManager.Services.Implementations
{
    internal class DepartmentService : IDepartmentService
    {
        public void AddDepartment(Department department)
        {
            using AirportdbContext db = new();
            bool checkIfExist = db.Departments.Any(e1 => e1.DepartmentId == department.DepartmentId);
            if (!checkIfExist)
            {
                db.Departments.Add(department);
                db.SaveChanges();
            }
        }

        public void UpdateDepartment(Department departmentBeforeChanges, string description)
        {
            using AirportdbContext db = new();
            Department? department = db.Departments.FirstOrDefault(a => a.DepartmentId == departmentBeforeChanges.DepartmentId);
            if (department != null)
            {
                department.Description = description;
            }
            db.SaveChanges();
        }

        public void DeleteDepartment(Department department)
        {
            using AirportdbContext db = new();
            db.Departments.Remove(department);
            db.SaveChanges();
        }

        public List<Department> GetAllDepartments()
        {
            using AirportdbContext db = new();
            var allDepartments = db.Departments.ToList();
            return allDepartments;
        }

        public Department GetDepartmentsById(int departmentId)
        {
            using AirportdbContext db = new();
            return db.Departments.FirstOrDefault(a => a.DepartmentId == departmentId);
        }
    }
}
