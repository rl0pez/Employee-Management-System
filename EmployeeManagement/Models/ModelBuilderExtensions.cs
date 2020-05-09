﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mark1",
                    Department = Dept.IT,
                    Email = "mark@davetech.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Diwash",
                    Department = Dept.IT,
                    Email = "diwash@davetech.com"
                },
                new Employee
                {
                    Id = 3,
                    Name = "Markintost",
                    Department = Dept.IT,
                    Email = "kintost@davetech.com"
                }
                );

        }
    }
}
