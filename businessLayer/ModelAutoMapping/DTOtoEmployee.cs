using AutoMapper;
using businessLayer.DTO.EmployeeDTO;
using EmployeeManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.ModelAutoMapping
{
    public class DTOtoEmployee : Profile
    {
        public DTOtoEmployee()
        {
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<Employee, EmployeeDTO>();
        }
    }
}
