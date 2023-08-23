using businessLayer.DTO.DepartmentDTO;

namespace businessLayer.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<DepartmentDTO> GetDepartment(int id);
        Task<IEnumerable<DepartmentDTO>> GetAllDepartments();
    }
}
