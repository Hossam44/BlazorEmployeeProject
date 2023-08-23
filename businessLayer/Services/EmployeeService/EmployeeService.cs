using AutoMapper;
using businessLayer.DTO.EmployeeDTO;
using EmployeeManagment.Api.Repositories.EmployeeRepo;
using EmployeeManagment.Models;


namespace businessLayer.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public async Task<EmployeeDTO> AddEmployee(EmployeeDTO employeeDTO)
        {
            return mapper.Map<EmployeeDTO>(await employeeRepository.AddEmployee(mapper.Map<Employee>(employeeDTO)));
        }

        public async Task<EmployeeDTO> DeleteEmployee(int id)
        {
            return mapper.Map<EmployeeDTO>(await employeeRepository.DeleteEmployee(id));
        }

        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployees()
        {
            return mapper.Map<IEnumerable<EmployeeDTO>>(await employeeRepository.GetEmployees());
        }

        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            return mapper.Map<EmployeeDTO>(await employeeRepository.GetEmployeeById(id));
        }

        public async Task<IEnumerable<EmployeeDTO>> Search(string name, Gender? gender)
        {
            IEnumerable<EmployeeDTO> employeesDTO = (await GetAllEmployees());

            if (name != null)
            {
                employeesDTO = employeesDTO.Where(e => e.FirstName == name || e.LastName == name);
            }
            if (gender != null)
            {
                employeesDTO = employeesDTO.Where(e => e.Gender == gender);
            }
            return employeesDTO;
        }

        public async Task<EmployeeDTO> UpdateEmployee(EmployeeDTO employeeDTO)
        {
            return mapper.Map<EmployeeDTO>(await employeeRepository.UpdateEmployee(mapper.Map<Employee>(employeeDTO)));
        }
    }
}

