using EmployeeManagment.Models;

namespace EmployeeManagment.Web.Services.EmployeeService
{
    public interface IEmployeeFetchService
    {

        Task<Employee> GetEmployeeById(int id);
        Task<Employee> UpdateEmployee(int id, Employee employee);
        Task<Employee> CreateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int id);

    }
}
