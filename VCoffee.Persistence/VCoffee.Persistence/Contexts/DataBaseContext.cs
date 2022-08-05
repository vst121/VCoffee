using VCoffee.Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCoffee.Domain.Entities.Products;

namespace VCoffee.Persistence.Contexts
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>  Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyQueryFilter(modelBuilder);
        }
 
        private void ApplyQueryFilter(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasQueryFilter(p => !p.IsRemoved);
        }
    }
}
