using businessLayer.DTO.DepartmentDTO;
using businessLayer.Services.DepartmentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMangement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await departmentService.GetAllDepartments());

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in reteriving Data From Data Base");
            }
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                DepartmentDTO departmentDTO = await departmentService.GetDepartment(id);
                if (departmentDTO == null)
                {
                    return NotFound();
                }
                return Ok(departmentDTO);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in reteriving Data From Data Base");
            }
        }
    }
}
