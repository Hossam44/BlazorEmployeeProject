using EmployeeManagment.Models;
using EmployeeManagment.Web.Services;
using EmployeeManagment.Web.Services.DepartmentServices;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class CreateEmployeeBase : ComponentBase
    {
        [Inject]
        public IDepartmentServices? DepartmentServices { get; set; }

        public Employee Employee { get; set; } = new Employee() { DepartmentID = 1};
        public IEnumerable<Department>? Departments { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Departments = await DepartmentServices!.GetDepartments();
        }
    }
}
