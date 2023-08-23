using EmployeeManagment.Models;

namespace EmployeeManagment.Web.Services.EmployeeService
{
    public interface IEmployeesFetchService
    {
        Task<IEnumerable<Employee>> GetEmployees();

    }
}
