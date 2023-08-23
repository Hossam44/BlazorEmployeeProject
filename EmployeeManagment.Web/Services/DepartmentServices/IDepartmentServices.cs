using EmployeeManagment.Models;

namespace EmployeeManagment.Web.Services.DepartmentServices
{
    public interface IDepartmentServices
    {
        Task<IEnumerable<Department>> GetDepartments();

    }
}
