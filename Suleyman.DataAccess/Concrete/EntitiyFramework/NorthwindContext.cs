using Microsoft.EntityFrameworkCore;
using Suleyman.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Suleyman.DataAccess.Concrete.EntitiyFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
