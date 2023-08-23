using EmployeeManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Web.Services.EmployeeService
{
    public class EmployeeService : IEmployeeFetchService, IEmployeesFetchService
    {
        private readonly HttpClient httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync($"api/Employee", employee);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Employee>();
            }

            return null!; // Return null if the creation was not successful
        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"api/Employee/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Employee>();
            }
            return null; // Return null if the Delete was not successful
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/Employee/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/Employee");
        }

        public async Task<Employee> UpdateEmployee(int id, Employee employee)
        {
            HttpResponseMessage response = await httpClient.PutAsJsonAsync($"api/Employee/{id}", employee);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Employee>();
            }

            return null; // Return null if the update was not successful
        }

    }
}
