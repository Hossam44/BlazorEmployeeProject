using EmployeeManagment.Models;
using EmployeeManagment.Web.Services.EmployeeService;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeesFetchService? employeeService { get; set; }
        public IEnumerable<Employee>? Employees { get; set; }

        public int countOfEmplyees { get; set; } = 0;
        public bool showFooter { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await Task.Run(() => employeeService.GetEmployees());
        }
        public void changeCountOfEmloyees(bool selected)
        {
            if(selected)
            {
                countOfEmplyees++;
            }
            else
            { 
                countOfEmplyees--; 
            }

        }
    }
}
