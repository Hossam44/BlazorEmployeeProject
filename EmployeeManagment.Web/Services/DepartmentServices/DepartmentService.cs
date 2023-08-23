using EmployeeManagment.Models;

namespace EmployeeManagment.Web.Services.DepartmentServices
{
    public class DepartmentService : IDepartmentServices
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetFromJsonAsync<Department[]>("api/Department");
        }
    }
}
