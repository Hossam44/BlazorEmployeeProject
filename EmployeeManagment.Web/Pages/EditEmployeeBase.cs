using EmployeeManagment.Models;
using EmployeeManagment.Web.Services.DepartmentServices;
using EmployeeManagment.Web.Services.EmployeeService;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeFetchService? EmployeeFetchService { get; set; }

        [Inject]
        public IDepartmentServices? DepartmentServices { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Employee? Employee { get; set; }

        [Parameter]
        public string? EmployeeId { get; set; }

        public IEnumerable<Department>? Departments { get; set; }
        protected async override Task OnInitializedAsync()
        {
            bool isNumeric = int.TryParse(EmployeeId, out int intValue);
            if (!isNumeric)
                EmployeeId = "1";

            Employee = await EmployeeFetchService!.GetEmployeeById(int.Parse(EmployeeId!));
            Departments = await DepartmentServices!.GetDepartments();
        }

    }
}
