
using EmployeeManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Api.Models
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT Department" },
                new Department { Id = 2, Name = "Marketing Department" },
                new Department { Id = 3, Name = "Finance Department" },
                new Department { Id = 4, Name = "Sales Department" }
            );

            // Seed Employees with relationships to departments
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1990, 5, 15),
                    Email = "john@example.com",
                    Gender = Gender.Male,
                    DepartmentID = 1, // Assign to IT Department
                    PhotoPath = "/images/john.jpg"
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1985, 9, 22),
                    Email = "jane@example.com",
                    Gender = Gender.Female,
                    DepartmentID = 2, // Assign to IT Department
                    PhotoPath = "/images/2.jpg"
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    DateOfBirth = new DateTime(1982, 3, 8),
                    Email = "michael@example.com",
                    Gender = Gender.Male,
                    DepartmentID = 3, // Assign to IT Department
                    PhotoPath = "/images/3.jpg"
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Williams",
                    DateOfBirth = new DateTime(1995, 11, 1),
                    Email = "Emily@example.com",
                    Gender = Gender.Female,
                    DepartmentID = 4, // Assign to IT Department
                    PhotoPath = "/images/4.jpg"
                }

                );
        }
    }
}
