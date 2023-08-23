using EmployeeManagment.Models;

namespace DataAccessLayer.Repo.DepartmentRepo
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int departmentId);
    }
}
