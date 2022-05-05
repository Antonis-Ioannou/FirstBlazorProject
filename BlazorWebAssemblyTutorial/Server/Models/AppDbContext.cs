using BlazorWebAssemblyTutorial.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssemblyTutorial.Server.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Bruce",
                LastName = "Jones",
                Email = "bruce@alphaSoftware.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/bruce.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Julie",
                LastName = "Adams",
                Email = "julie@alphaSoftware.com",
                DateOfBirth = new DateTime(1984, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/julie.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Ian",
                LastName = "Claff",
                Email = "ian@alphaSoftware.com",
                DateOfBirth = new DateTime(1983, 12, 4),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/ian.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Loreena",
                LastName = "Rush",
                Email = "loreena@alphaSoftware.com",
                DateOfBirth = new DateTime(1981, 09, 12),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/loreena.png"
            });
        }
    }
}
