using AutoMapper;
using businessLayer.DTO.DepartmentDTO;
using businessLayer.DTO.EmployeeDTO;
using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.ModelAutoMapping
{
    public class DTOtoDepartment : Profile
    {
        public DTOtoDepartment()
        {
            CreateMap<DepartmentDTO, Department>();
            CreateMap<Department, DepartmentDTO>();
        }
    }
}
