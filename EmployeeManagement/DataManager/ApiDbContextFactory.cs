using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.DataManager
{
    public class ApiDbContextFactory : DbContext
    {
        public ApiDbContextFactory(DbContextOptions<ApiDbContextFactory> options) : base(options)
        {

        }
        public DbSet<VMInstanceSSMCommandIdMappings> VMInstanceSSMCommandIdMappings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VMInstanceSSMCommandIdMappings>().ToTable("VMInstanceSSMCommandIdMappings");
           
        }
    }
}
