using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string? Name { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; } 

    }
}