using businessLayer.DTO.DepartmentDTO;
using businessLayer.DTO.EmployeeDTO;
using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<EmployeeDTO> GetEmployee(int id);
        Task<IEnumerable<EmployeeDTO>> GetAllEmployees();

        Task<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO);

        Task<EmployeeDTO> UpdateEmployee(EmployeeDTO employeeDTO);

        Task<EmployeeDTO> DeleteEmployee(int id);

        Task<IEnumerable<EmployeeDTO>> Search(string name, Gender? gender);
    }
}
