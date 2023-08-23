using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.DTO.EmployeeDTO
{

    public record EmployeeDTO(
        int Id,
        string? FirstName,
        string? LastName,
        string? Email,
        DateTime DateOfBirth,
        Gender Gender,
        string? PhotoPath,
        int DepartmentID,
        Department? Department
    );
}
