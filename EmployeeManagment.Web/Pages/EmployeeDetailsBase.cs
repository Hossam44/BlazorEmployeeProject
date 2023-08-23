using EmployeeManagment.Models;
using EmployeeManagment.Web.Services.EmployeeService;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        [Parameter]
        public string? id { get; set; }

        public Employee employee { get; set; } = new Employee();

        public string buttonText { get; set; } = "Hide";

        public string? hide { get; set; } = null;

        public void onClick()
        {
            if(buttonText=="Hide")
            {
                buttonText = "Display";
                hide = "hide";
            }
            else
            {
                buttonText = "Hide";
                hide = null;
            }
        }

        [Inject]
        public  IEmployeeFetchService? EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            bool isNumeric = int.TryParse(id, out int intValue);
            if(!isNumeric)
                id = "1";

            employee = await EmployeeService!.GetEmployeeById(int.Parse(id));
        }

    }
}
