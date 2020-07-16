using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnMVCUsingEFCodeFirst.Entities
{
    public class EmployeeContext:DbContext
    {
        //Entity sets
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=EMS;User ID=sa;Password=pass@word1");
        }
    }
}
