using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.DTO.DepartmentDTO
{

    public record DepartmentDTO(
       int Id,
       string? Name,
       ICollection<Employee>? Employees
    );
}
