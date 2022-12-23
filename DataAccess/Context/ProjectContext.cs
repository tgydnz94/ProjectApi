using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Context
{
    public class ProjectContext : DbContext
    {
        //public ProjectContext(DbContextOptions <ProjectContext> options) 
        //{
        //    Migrationsa kadar yorumda duracak
        //}

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=projectApiDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
