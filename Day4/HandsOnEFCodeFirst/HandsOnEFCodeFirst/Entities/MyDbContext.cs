using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst.Entities
{
    class MyDbContext:DbContext
    {
        //Entity Sets(Dbsets)
        public DbSet<Product> Products { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string tells which server it connects and wrt which db transactions are performed.
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=ProductDB;User ID=sa;Password=pass@word1");
        }

    }
}
