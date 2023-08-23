using EmployeeManagment.Models;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public Employee? employee { get; set; }
        [Parameter]
        public bool checkpoint { get; set; }

        [Parameter]
        public EventCallback<bool> checkpointChanged { get; set; }

        public async void chekBoexChanged(ChangeEventArgs e)
        {
            await checkpointChanged.InvokeAsync((bool)e.Value);
        }

    }
}
