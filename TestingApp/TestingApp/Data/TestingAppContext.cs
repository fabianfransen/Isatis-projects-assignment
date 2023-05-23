using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestingApp.Models;


namespace TestingApp.Data
{

    public class TestingAppContext : DbContext
    {

        public TestingAppContext (DbContextOptions<TestingAppContext> options)
            : base(options)
        {
        }
        public DbSet<Planning> Plannings { get; set; } = default!;
        public DbSet<Project> Projects { get; set; } = default!;

        public DbSet<Employee> Employees { get; set; } = default!;


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planning>()
            .ToTable("Planning");

            modelBuilder.Entity<Project>().HasData(
            new Project
            {
                Id = 1,
                Name = "Project 1",
            }
         );
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                Name = "Kees",
                ContractHours = 40
            }
            );
            modelBuilder.Entity<Planning>().HasData(
            new Planning
            {
                Id = 1,
                Week = 1,
                Hours = 40,
                ProjectId = 1,
                EmployeeId = 1
            }
                 );
        }

    }
}
