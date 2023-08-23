using EmployeeManagment.Api.Models;
using EmployeeManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Api.Repositories.EmployeeRepo
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDpContext;
        public EmployeeRepository(AppDbContext appDpContext)
        {
            this.appDpContext = appDpContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDpContext.Employees.AddAsync(employee);
            await appDpContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId)
        {
            var result = await appDpContext.Employees
                .FirstOrDefaultAsync(e => e.Id == employeeId);
            if (result != null)
            {
                appDpContext.Employees.Remove(result);
                await appDpContext.SaveChangesAsync();
            }
            return result!;
        }

        public async Task<Employee> GetEmployeeById(int Id)
        {
            return await appDpContext.Employees.Include(e=>e.Department).FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDpContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> employeeList = appDpContext.Employees;
            if (name != null)
            {
                employeeList = appDpContext.Employees.Where(e => e.FirstName == name || e.LastName == name);
            }
            if(gender != null)
            {
                employeeList = employeeList.Where(e=>e.Gender==gender);
            }
            return await employeeList.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDpContext.Employees
                .FirstOrDefaultAsync(e => e.Id == employee.Id);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentID = employee.DepartmentID;
                result.PhotoPath = employee.PhotoPath;

                await appDpContext.SaveChangesAsync();

                return result;
            }

            return null!;
        }
    }
}
