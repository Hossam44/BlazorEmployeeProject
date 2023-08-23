using EmployeeManagment.Models;
using EmployeeManagment.Web.Services.EmployeeService;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class FormEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeFetchService? EmployeeFetchService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public Employee? Employee { get; set; }

        [Parameter]
        public IEnumerable<Department>? Departments { get; set; }

        [Parameter]
        public string? TypeOfOperation { get; set; }
        public async void validSubmit()
        {
            if(TypeOfOperation == "Create")
            {
                NavigationManager.NavigateTo("/");

                if (await EmployeeFetchService?.CreateEmployee(Employee) != null)
                {
                    NavigationManager.NavigateTo("/");
                }
            }
            else
            {
                if (await EmployeeFetchService?.UpdateEmployee(Employee.Id, Employee) != null)
                {
                    NavigationManager.NavigateTo("/");
                }
            }
        }

        public async void DeleteEmployee()
        {
            var emp = EmployeeFetchService.DeleteEmployee(Employee.Id);
            if(emp != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
