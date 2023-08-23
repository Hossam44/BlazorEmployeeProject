using AutoMapper;
using businessLayer.DTO.DepartmentDTO;
using DataAccessLayer.Repo.DepartmentRepo;

namespace businessLayer.Services.DepartmentService
{
    public class DepartmenService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DepartmenService(IDepartmentRepository departmentRepository,IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentDTO>> GetAllDepartments()
        {
            return mapper.Map<IEnumerable<DepartmentDTO>>(await departmentRepository.GetDepartments());
        }

        public async Task<DepartmentDTO> GetDepartment(int id)
        {
            return mapper.Map<DepartmentDTO>(await departmentRepository.GetDepartment(id));
        }
    }
}
