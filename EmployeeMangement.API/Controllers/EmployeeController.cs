using businessLayer.DTO.EmployeeDTO;
using businessLayer.Services.EmployeeService;
using EmployeeManagment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMangement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        // GET: api/<EmployeeController>

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()                                       //Get All Employees From Data Base
        {
            try
            {
                return Ok(await employeeService.GetAllEmployees());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in reteriving Data From Data Base");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                EmployeeDTO employeeDTO = await employeeService.GetEmployee(id);
                if (employeeDTO == null)
                {
                    return NotFound();
                }
                return Ok(employeeDTO);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in reteriving Data From Data Base");
            }

        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeDTO employeeDTO)
        {
            try
            {
                if (employeeService == null)
                {
                    return BadRequest();
                }
                EmployeeDTO empDTO = await employeeService.AddEmployee(employeeDTO);
                return CreatedAtAction("Get", new { id = empDTO.Id }, empDTO);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in adding Data to Data Base");
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] EmployeeDTO employeeDTO)
        {
            try
            {
                if (employeeDTO == null)
                    return BadRequest();
                if (employeeDTO.Id != id)
                    return BadRequest();
                var testEmployee = await employeeService.GetEmployee(id);
                if (testEmployee == null)
                    return NotFound();

                return Ok(await employeeService.UpdateEmployee(employeeDTO));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in adding Data to Data Base");
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var testemployee = await employeeService.GetEmployee(id);
                if (testemployee == null)
                    return BadRequest("This Email Not Found");
                return Ok(await employeeService.DeleteEmployee(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in adding Data to Data Base");
            }

        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(string name, Gender? gender)
        {
            try
            {
                var employeeList = await employeeService.Search(name, gender);

                if (employeeList.Any())
                {
                    return Ok(employeeList);
                }
                return NotFound();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in adding Data to Data Base");
            }
        }
    }
}
